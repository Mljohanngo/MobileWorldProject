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
    
    public class IndexModel : PageModel
    {
        private readonly MWService _mWService;
        private string clientIpAddress;
        public IndexModel(MWService mWService)
        {
            _mWService = mWService;
        }

        [BindProperty]
        [Required(ErrorMessage = "Msisdn is required")]
        public long Msisdn { get; set; }
        public void OnGet()
        {
            clientIpAddress = HttpContext.Connection.RemoteIpAddress?.ToString() ?? "176.205.206.244";
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
                    Msisdn = Msisdn.ToString(),
                    SourceIp = clientIpAddress,
                    Channel = "web",
                    AdPartnerName = "MLCampaign"
                });
                return RedirectToPage("Pin", sendPINResponse);
            }
            catch (Exception ex)
            {
                return Page();
            }
        }
    }
}
