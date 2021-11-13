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
    public class PinModel : PageModel
    {
        private readonly MWService _mWService;
        public PinModel(MWService mWService)
        {
            _mWService = mWService;
        }

        [BindProperty]
        [Required(ErrorMessage = "OTP is required")]
        public long Otp { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {

        }
    }
}
