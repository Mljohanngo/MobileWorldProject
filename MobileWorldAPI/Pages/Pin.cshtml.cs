using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DTO.MW;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MWProxy;

namespace MobileWorldAPI.Pages
{
    public class PinModel : PageModel
    {
        private readonly MWService _mWService;
        private string clientIpAddress;
        public PinModel(MWService mWService)
        {
            _mWService = mWService;
        }

        [BindProperty]
        [Required(ErrorMessage = "PinResponse is required")]
        public SendPinResponseDto SendPinResponseDto { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "OTP is required")]
        public long Otp { get; set; }
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
                return Page();
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

            }
            catch (Exception)
            {
                return Page();
            }
            return RedirectToPage("Welcome");
        }
    }
}
