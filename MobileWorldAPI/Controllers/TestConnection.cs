using DTO.MW;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.MWProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileWorldAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestConnection : ControllerBase
    {
        private readonly MWService _mWService;

        public TestConnection(MWService mWService)
        {
            _mWService = mWService;
        }

        [HttpPost]
        [Route("SendPin")]
        public async Task<IActionResult> SendPin([FromBody] SendPinRequestDto request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var response = await _mWService.SendPinAsync(request);

            return Ok(response);
        }

        [HttpPost]
        [Route("ConfirmPin")]
        public async Task<IActionResult> ConfirmPin([FromBody] ConfirmPinRequestDto request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var response = await _mWService.ConfirmPinAsync(request);
            return Ok(response);
        }

        [HttpPost]
        [Route("ResendPin")]
        public async Task<IActionResult> ResendPin([FromBody] ResendPinRequestDto request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var response = await _mWService.ReSendPinAsync(request);
            return Ok(response);
        }

        [HttpPost]
        [Route("CancelSubscription")]
        public async Task<IActionResult> CancelSubscription([FromBody] CancelSubscriptionRequestDto request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var response = await _mWService.CancelSubscriptionAsync(request);
            return Ok(response);
        }

        [HttpPost]
        [Route("CheckSubscription")]
        public async Task<IActionResult> CheckSubscription([FromBody] CheckSubscriptionRequestDto request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var response = await _mWService.CheckSubscriptionAsync(request);
            return Ok(response);
        }


    }
}
