using Data_Access.Context;
using DTO.Affiliates;
using Entities;
using Helper.Service;
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
        private readonly AffiliateDBContext _AffilateDBContext;

        public AffiliateController(AffiliateDBContext affContext)
        {
            _AffilateDBContext = affContext;
        }

        [HttpGet]
        [Route("Subscribe/{service}")]
        public async Task<ActionResult> SubscribeAsync([FromQuery] AffiliateDto affiliateData)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var result = await _AffilateDBContext.Set<TblReferralHit>().AddAsync(new TblReferralHit
                {
                    IdCampaign = affiliateData.Mip_Prt,
                    TransactionId = affiliateData.Mip_Afc,
                    CreateDate = ConvertTime.toUAEDateTime(DateTime.UtcNow),
                    IpAddress = HttpContext.Connection.RemoteIpAddress?.ToString() ?? "176.205.206.244",
                    UserAgent = Request.Headers["User-Agent"].ToString(),
                    Promo = ""

                });

                await _AffilateDBContext.SaveChangesAsync();
                affiliateData.Id_Hit = result.Entity.IdHit;
                affiliateData.Ip_Address = result.Entity.IpAddress;

                // Logica del HIt y Subs en Pending
                return RedirectToPage("/Index", affiliateData);
            }
            catch (Exception)
            {
                return RedirectToPage("/Failure");
            }
        }
    }
}
