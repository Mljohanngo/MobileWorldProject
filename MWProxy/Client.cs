using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWProxy
{
    public class Client
    {
        private readonly IConfiguration Configuration;
        private readonly IHttpClientFactory _clientFactory;
        public Client(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public static object SendPin(object SendPinDto)
        {
            return null;
        }
    }
}
