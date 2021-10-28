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
            client.BaseAddress = new Uri(_configuration.GetValue<string>("MWConfig:HTTP:BaseUrl"));
            var headerValue = $"{_configuration.GetValue<string>("MWConfig:Credentials:UserName")}:{_configuration.GetValue<string>("MWConfig:Credentials:PassWord")}";
            client.DefaultRequestHeaders.Add($"{_configuration.GetValue<string>("MWConfig:HTTP:Header")}", 
                $"{Convert.ToBase64String(Encoding.ASCII.GetBytes(headerValue))}");
            _httpClient = client;
        }

        public async Task<SendPinRequestDto> SendPinAsync(SendPinRequestDto Request, string config)
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
