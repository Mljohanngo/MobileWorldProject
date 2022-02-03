using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Data_Access.Context;
using Entities;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Service.MWProxy;

namespace MobileWorldAPI.Pages
{
    
    public class IndexarModel : PageModel
    {
        private readonly MWService _mWService;
        private string clientIpAddress;

        private string mip_afc;

        private int mip_prt;
        private readonly MWDBContext _MWContext;

        private readonly AffiliateDBContext _Affilatectxt;
        public IndexarModel(MWService mWService, MWDBContext mwContext, AffiliateDBContext affContext)
        {
            _mWService = mWService;
            _MWContext= mwContext;
            _Affilatectxt=affContext;
        }

        [BindProperty]
        //[Phone(ErrorMessage = "Please insert a valid number")]
        [Required(ErrorMessage = "Number is required")]
        [RegularExpression(@"^05(0|4|6)\d{7}$", ErrorMessage = "Please enter a valid Etisalat number")]
        public string Msisdn { get; set; }
        public string BaseImg { get; set; }
        public IActionResult OnGet([FromRoute] int id = 0,string afc="", int prt=0)
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
            clientIpAddress = HttpContext.Connection.RemoteIpAddress?.ToString() ?? "176.205.206.244";

            mip_afc=afc;
            mip_prt=prt;

            return Page();
        }

        public async Task<IActionResult> OnPost([FromQuery] string afc=null, int prt=0)
        {
            clientIpAddress = HttpContext.Connection.RemoteIpAddress?.ToString() ?? "176.205.206.244";

            mip_afc=afc;
            mip_prt=prt;

            Msisdn = $"9715{Msisdn.Substring(2,8)}";


            try{
                if(mip_prt!=0){
                var create_hit=new TblReferralHit(){
                    
                    IdCampaign=mip_prt,
                    TransactionId=mip_afc,
                    Msisdn=Msisdn,
                    CreateDate = DateTime.Now,
                    IpAddress=clientIpAddress,
                    UserAgent=Request.Headers["User-Agent"].ToString(),
                    Promo=""
                };

                var datos=_Affilatectxt.TblReferralHits.Add(create_hit);
                var r = _Affilatectxt.SaveChanges();
                }
            }
            catch (Exception)
            {
            return Page();
            }

            try
            {
                var validateUser = _MWContext.Subscription.Where(p=>p.Msisdn==Msisdn).Where(p=>p.Status=="ACTIVE").SingleOrDefault();

                if(validateUser!=null)
                {
                    return Redirect("https://megaplay.digi-vibe.com/?sugid=cd01de3a-e5ae-434c-b926-ec127d1cde3b");
                }

                if (!ModelState.IsValid)
                {
                  return Redirect("Failure");
                }

                
                
                var sendPINResponse = await _mWService.SendPinAsync(new DTO.MW.SendPinRequestDto
                {
                    Msisdn = Msisdn,
                    SourceIp = clientIpAddress,
                    Channel = "web",
                    AdPartnerName = "MLCampaign"
                });

                

                /*if(sendPINResponse.ResponseCode==0)
                {
                var clientCorrelator = _MWContext.Set<Subscription>().Where(p=>p.Id==1).FirstOrDefault();
                var pinresult= new MWSendPin(){
                    SubscriptionId=sendPINResponse.SubscriptionId,
                    Action="1",
                    Msisdn=sendPINResponse.Msisdn,
                    ProductId="1",
                    Language="en",
                    ClientCorrelator="80",
                    SourceIp=clientIpAddress,
                    PubId="MLDG",
                    Channel="web",
                    AdPartnerName="test",
                    HttpResponseCode=200,
                    ResponseMessage=sendPINResponse.re
                                                                                                                                                                           


                }  
                }*/


                return RedirectToPage("Pin", sendPINResponse);

                

                //return Redirect("Error");
            }
            catch (Exception)
            {
                return Redirect("Failure");
            }
        }
    }
}
