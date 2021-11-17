using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MWProxy;

namespace MobileWorldAPI.Pages
{
    
    public class IndexModelAr : PageModel
    {
        private readonly MWService _mWService;
        private string clientIpAddress;
        public IndexModelAr(MWService mWService)
        {
            _mWService = mWService;
        }

        [BindProperty]
        [Required(ErrorMessage = "Msisdn is required")]
        public long Msisdn { get; set; }
        public string BaseImg { get; set; }
        public IActionResult OnGet([FromRoute] int id = 0)
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
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                  return Page();
                }

                var sendPINResponse = await _mWService.SendPinAsync(new DTO.MW.SendPinRequestDto
                {
                    Msisdn = $"971{Msisdn}",
                    SourceIp = clientIpAddress,
                    Channel = "web",
                    AdPartnerName = "MLCampaign"
                });
                return RedirectToPage("Pin", sendPINResponse);
            }
            catch (Exception)
            {
                return Page();
            }
        }
    }
}