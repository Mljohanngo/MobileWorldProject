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
        private SendPinResponseDto _sendPinResponseDto;
        private string clientIpAddress;
        public PinModel(MWService mWService)
        {
            _mWService = mWService;
        }

        [BindProperty]
        [Required(ErrorMessage = "OTP is required")]
        public long Otp { get; set; }
        public void OnGet(SendPinResponseDto passedData)
        {
            clientIpAddress = HttpContext.Connection.RemoteIpAddress?.ToString() ?? "176.205.206.244";
            _sendPinResponseDto = passedData;
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
                    Msisdn = _sendPinResponseDto.Msisdn,
                    SubscriptionId = _sendPinResponseDto.SubscriptionId,
                    TransactionId = _sendPinResponseDto.TransactionId,
                    SourceIp = clientIpAddress,
                    Channel = "web",
                    AdPartnerName = "MLCampaign"
                });

            }
            catch (Exception)
            {
                return Page();
            }
            return Redirect("/Pin");
        }
    }
}
