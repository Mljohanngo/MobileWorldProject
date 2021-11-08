using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MWProxy;
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


    }
}
