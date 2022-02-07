using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Data_Access.Context;
using DTO.Affiliates;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Service.MWProxy;

namespace MobileWorldAPI.Pages
{
    
    public class IndexModel : PageModel
    {
        private readonly MWService _mWService;
        private readonly MWDBContext _MWContext;
        private readonly AffiliateDBContext _AffilateDBContext;

        public IndexModel(MWService mWService, MWDBContext mwContext, AffiliateDBContext affContext)
        {
            _mWService = mWService;
            _MWContext = mwContext;
            _AffilateDBContext = affContext;
        }

        [BindProperty]
        [RegularExpression(@"\d{8}$", ErrorMessage = "Please insert a valid number")]
        [Required(ErrorMessage = "Your mobile number is required")]
        [MaxLength(8, ErrorMessage = "Please enter 8 digits of your mobile number")]
        [MinLength(8, ErrorMessage = "Please enter 8 digits of your mobile number")]
        // [RegularExpression(@"^05(0|4|6)\d{7}$", ErrorMessage = "Please enter a valid Etisalat number")]
        public string Msisdn { get; set; }
        //public string Msisdn { get; set; }
        public string BaseImg { get; set; }

        public IActionResult OnGet( [FromRoute] int id = 0)
        {

            switch (id)
            {
                case 1:
                    BaseImg = "img/landing1.png";
                    break;
                case 2:
                    BaseImg = "img/landing2.png";
                    break;
                case 3:
                    BaseImg = "img/landing3.png";
                    break;
                default:
                    BaseImg = "img/landing1.png";
                    break;
            }

            //TODO: Hanlde auto redirect for subscribed users
            

            return Page();
        }

        public async Task<IActionResult> OnPost(AffiliateDto passedData)
        {

            try
            {
                if (!ModelState.IsValid)
                {
                    return Redirect("Failure");
                }

                // User Exists and is Active
                var isSubscribed = _MWContext.Set<Subscription>()
                    .Where(p => p.Msisdn == String.Concat("9715", Msisdn) && p.Status == "ACTIVE")
                    .OrderByDescending(p => p.Id)
                    .FirstOrDefault();

                if (isSubscribed != null)
                {
                    return Redirect("https://megaplay.digi-vibe.com/?sugid=cd01de3a-e5ae-434c-b926-ec127d1cde3b");
                }

                // Getting current Hit

                var updateHit = _AffilateDBContext.Set<TblReferralHit>()
                    .Where(p => p.IdHit == passedData.Id_Hit).FirstOrDefault();

                if (updateHit == null)
                {
                    return Redirect("Failure");
                }

                // Updating Hit

                updateHit.Msisdn = String.Concat("9715", Msisdn);
                _AffilateDBContext.Set<TblReferralHit>().Attach(updateHit);
                _AffilateDBContext.Entry(updateHit).State = EntityState.Modified;
                await _AffilateDBContext.SaveChangesAsync();

                // Send Pin

                var response = await _mWService.SendPinAsync(new DTO.MW.SendPinRequestDto
                {
                    Msisdn = updateHit.Msisdn,
                    SourceIp = updateHit.IpAddress,
                    Channel = "web",
                    //TODO: Add logic to handle different Partner Campaigns
                    AdPartnerName = "MLCampaign"
                });

                response.Ip = passedData.Ip_Address;

                // Creating Send Pin Record

                var sendPin = await _MWContext.Set<MWSendPin>().AddAsync(new MWSendPin
                {
                    Msisdn = response.Msisdn,
                    SourceIp = response.Ip,
                    Channel = "web",
                    AdPartnerName = "MLCampaign",
                    OpSubscriptionId = response.SubscriptionId,
                    TrxID = response.TransactionId,
                    ResultMessage = response.ResponseDescription.StatusMessage


                });




                return RedirectToPage("Pin", response);

                

                //return Redirect("Error");
            }
            catch (Exception)
            {
                return Redirect("Failure");
            }
        }
    }
}
