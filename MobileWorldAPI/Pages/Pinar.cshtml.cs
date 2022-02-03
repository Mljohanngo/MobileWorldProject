using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Data_Access.Context;
using DTO.MW;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Service.MWProxy;

namespace MobileWorldAPI.Pages
{
    public class PinarModel : PageModel
    {
        private readonly MWService _mWService;
        private string clientIpAddress;
       
        private readonly MWDBContext _MWContext;
        public PinarModel(MWService mWService, MWDBContext mwContext )
        {
            _mWService = mWService;
            _MWContext= mwContext;
        }

        [BindProperty]
        [Required(ErrorMessage = "PinResponse is required")]
        public SendPinResponseDto SendPinResponseDto { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "OTP is required")]
        public long Otp { get; set; }

        public string MessageRes { get; set; }
        public IActionResult OnGet(SendPinResponseDto passedData)
        {
            clientIpAddress = HttpContext.Connection.RemoteIpAddress?.ToString() ?? "176.205.206.244";
            if (passedData is null || !ModelState.IsValid)
            {
                return RedirectToPage("Index");
            }
            SendPinResponseDto = passedData;
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Redirect("Failure");
            }
            try
            {
                
                var confirmPINResponse = await _mWService.ConfirmPinAsync(new DTO.MW.ConfirmPinRequestDto
                {
                    Msisdn = SendPinResponseDto.Msisdn,
                    SubscriptionId = SendPinResponseDto.SubscriptionId,
                    TransactionId = SendPinResponseDto.TransactionId,
                    SourceIp = clientIpAddress,
                    Channel = "web",
                    PinCode = Otp.ToString(),
                    AdPartnerName = "MLCampaign"
                });

                /*if (confirmPINResponse.ResponseCode != 0)
                {
                    // Es un error
                    MessageRes=confirmPINResponse.ErrorMessage;  
                    return Page();
                }*/
                
                //var url = _MWContext.Product.Where(p => p.Id == 1).FirstOrDefault();
                var subs = new Subscription() {
                    CreateDate = DateTime.Now,
                    Msisdn = confirmPINResponse.Msisdn,
                    Key = 1,
                    Status = confirmPINResponse.ResponseCode == 0 ? "ACTIVE" : "FAILED",
                    CancelDate = DateTime.Now,
                    LastRenew = DateTime.Now,
                    NextRenew = DateTime.Now,
                    LastSuccessfulRenew = DateTime.Now,
                    IdOperator = 2501,
                    EventSource = "WEB",
                    ContentUrl = "https://megaplay.digi-vibe.com/"

                };
                var datos=_MWContext.Subscription.Add(subs);
                var r = _MWContext.SaveChangesAsync();
                
                //return RedirectToPage("Welcome", confirmPINResponse);
                return RedirectToPage("Welcomear", subs);

            }
            catch (Exception)
            {
                MessageRes = "Error entering the OTP";
                return Redirect("Failure");
            }
            
        }
    }
}
