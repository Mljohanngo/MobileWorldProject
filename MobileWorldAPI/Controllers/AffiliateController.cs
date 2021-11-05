using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileWorldAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AffiliateController : ControllerBase
    {
        [HttpGet]
        [Route("Index")]
        public ActionResult Subscribe() 
        {
            // Logica del HIt y Subs en Pending
            return Redirect("https://localhost:44393/Index");
        }
    }
}
