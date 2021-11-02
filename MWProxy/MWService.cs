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
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        public MWService(HttpClient client, IConfiguration configuration) 
        {
            client.BaseAddress = new Uri(configuration.GetValue<string>("MWConfig:HTTP:BaseUrl"));
            var headerValue = $"" +
                              $"{configuration.GetValue<string>("MWConfig:Credentials:UserName")}" +
                              $":{configuration.GetValue<string>("MWConfig:Credentials:PassWord")}";
            client.DefaultRequestHeaders.Add(
                              $"{configuration.GetValue<string>("MWConfig:HTTP:Header")}",
                              $"{Convert.ToBase64String(Encoding.ASCII.GetBytes(headerValue))}");

            _httpClient = client;
            _configuration = configuration;
        }

        public async Task<SendPinRequestDto> SendPinAsync(SendPinRequestDto Request)
        {

            var client = await _httpClient.PostAsJsonAsync(_httpClient.BaseAddress, new { test = "test"});
            return null;
        }

        public async Task<ReSendPinResponseDto> ReSendPinAsync(ReSendPinRequestDto Request)
        {
            var client = await _httpClient.PostAsJsonAsync(_httpClient.BaseAddress, new { test = "test" });
            return null;
        }

        public async Task<ConfirmPinResponseDto> ConfirmPinAsync(ConfirmPinRequestDto Request)
        {
            var client = await _httpClient.PostAsJsonAsync(_httpClient.BaseAddress, new { test = "test" });
            return null;
        }

        public async Task<CheckSubscriptionResponseDto> CheckSubscriptionAsync(CheckSubscriptionRequestDto Request)
        {
            var client = await _httpClient.PostAsJsonAsync(_httpClient.BaseAddress, new { test = "test" });
            return null;
        }

        public async Task<CancelSubscriptionResponseDto> CancelSubscriptionAsync(CancelSubscriptionRequestDto Request)
        {
            var client = await _httpClient.PostAsJsonAsync(_httpClient.BaseAddress, new { test = "test" });
            return null;
        }

        public async Task<SendFreeMTResponseDto> SendFreeMTAsync(SendFreeMTRequestDto Request)
        {
            var client = await _httpClient.PostAsJsonAsync(_httpClient.BaseAddress, new { test = "test" });
            return null;
        }
    }
}
