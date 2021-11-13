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
        public IndexModel(MWService mWService)
        {
            _mWService = mWService;
        }

        [BindProperty]
        [Required(ErrorMessage = "Msisdn is required")]
        public long Msisdn { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {

        }
    }
}
