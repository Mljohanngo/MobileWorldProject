using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileWorldAPI.Controllers
{
    [Route("api/uae/Affiliate")]
    [ApiController]
    public class AffiliateController : ControllerBase
    {
        [HttpGet]
        [Route("Subscribe/{service}")]
        public ActionResult Subscribe() 
        {
            // Logica del HIt y Subs en Pending
            return Redirect("https://uae.digi-vibe.com/index|");
        }
    }
}
