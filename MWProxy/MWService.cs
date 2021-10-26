using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;

namespace MWProxy
{
    public class MWService
    {
        private readonly IConfiguration _configuration;
        public HttpClient Client { get; }
        public MWService(IConfiguration configuration, HttpClient client)
        {
            client.BaseAddress = new Uri("https://api.github.com/");
            // GitHub API versioning
            client.DefaultRequestHeaders.Add("Accept",
                "application/vnd.github.v3+json");
            // GitHub requires a user-agent
            client.DefaultRequestHeaders.Add("User-Agent",
                "HttpClientFactory-Sample");

            Client = client;

        }

        public async Task<SendPinRequestDto> SendPinAsync(SendPinRequestDto Request)
        {

            var client = await Client.PostAsJsonAsync(Client.BaseAddress, new { test = "test"});
            return null;
        }

        public async Task<ReSendPinResponseDto> ReSendPinAsync(ReSendPinRequestDto Request)
        {
            var client = await Client.PostAsJsonAsync(Client.BaseAddress, new { test = "test" });
            return null;
        }

        public async Task<ConfirmPinResponseDto> ConfirmPinAsync(ConfirmPinRequestDto Request)
        {
            var client = await Client.PostAsJsonAsync(Client.BaseAddress, new { test = "test" });
            return null;
        }

        public async Task<CheckSubscriptionResponseDto> CheckSubscriptionAsync(CheckSubscriptionRequestDto Request)
        {
            var client = await Client.PostAsJsonAsync(Client.BaseAddress, new { test = "test" });
            return null;
        }

        public async Task<CancelSubscriptionResponseDto> CancelSubscriptionAsync(CancelSubscriptionRequestDto Request)
        {
            var client = await Client.PostAsJsonAsync(Client.BaseAddress, new { test = "test" });
            return null;
        }

        public async Task<SendFreeMTResponseDto> SendFreeMTAsync(SendFreeMTRequestDto Request)
        {
            var client = await Client.PostAsJsonAsync(Client.BaseAddress, new { test = "test" });
            return null;
        }
    }
}
