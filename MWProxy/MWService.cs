﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

using DTO.MW;
using System.Text.Json;

namespace Service.MWProxy
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
            var headerBase64 = Convert.ToBase64String(Encoding.ASCII.GetBytes(headerValue));
            client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", headerBase64);

            _httpClient = client;
            _configuration = configuration;
        }

        public async Task<SendPinResponseDto> SendPinAsync(SendPinRequestDto Request)
        {
            Request.Action = _configuration.GetValue<string>("MWConfig:Method:SendPin:Action");
            Request.ProductId = _configuration.GetValue<string>("MWConfig:Credentials:ProductId");
            Request.Language = _configuration.GetValue<string>("MWConfig:Credentials:Language");
            Request.ClientCorrelator = Guid.NewGuid().ToString();
            Request.PubId = _configuration.GetValue<string>("MWConfig:Credentials:PubId");
            var result = await _httpClient.PostAsJsonAsync("request", Request);

            if (!result.IsSuccessStatusCode)
            {
                throw new Exception($"Error , code {result.StatusCode}");
            }

            var payload = await result.Content.ReadAsStringAsync();
            var response = JsonSerializer.Deserialize<SendPinResponseDto>(payload);

            if (response.ResponseCode != 0)
            {
                switch (response.ResponseCode)
                {
                    case -1:
                        throw new Exception($"Error Number, code {response.ResponseCode}");
                    default:
                        throw new Exception($"Error, code {response.ResponseCode}");
                }
               
            }
            return response;
        }

        public async Task<ResendPinResponseDto> ReSendPinAsync(ResendPinRequestDto Request)
        {
            var result = await _httpClient.PostAsJsonAsync("request", Request);

            if (!result.IsSuccessStatusCode)
            {
                throw new Exception($"Error , code {result.StatusCode}");
            }
            var payload = await result.Content.ReadAsStringAsync();
            var response = JsonSerializer.Deserialize<ResendPinResponseDto>(payload);
            return response;
        }

        public async Task<ConfirmPinResponseDto> ConfirmPinAsync(ConfirmPinRequestDto Request)
        {
            Request.Action = _configuration.GetValue<string>("MWConfig:Method:ConfirmPin:Action");
            Request.ProductId = _configuration.GetValue<string>("MWConfig:Credentials:ProductId");
            Request.PubId = _configuration.GetValue<string>("MWConfig:Credentials:PubId");
            var result = await _httpClient.PostAsJsonAsync("request", Request);

            if (!result.IsSuccessStatusCode)
            {
                throw new Exception($"Error , code {result.StatusCode}");
            }
            var payload = await result.Content.ReadAsStringAsync();
            var response = JsonSerializer.Deserialize<ConfirmPinResponseDto>(payload);

            if (response.ResponseCode != 0)
            {
                switch (response.ResponseCode)
                {
                    case -1:
                        throw new Exception($"Error Invalid Pin, code {response.ResponseCode}");
                    default:
                        throw new Exception($"Error, code {response.ResponseCode}");
                }

            }
            return response;
        }

        public async Task<CheckSubscriptionResponseDto> CheckSubscriptionAsync(CheckSubscriptionRequestDto Request)
        {
            var result = await _httpClient.PostAsJsonAsync("request", Request);

            if (!result.IsSuccessStatusCode)
            {
                throw new Exception($"Error , code {result.StatusCode}");
            }
            var payload = await result.Content.ReadAsStringAsync();
            var response = JsonSerializer.Deserialize<CheckSubscriptionResponseDto>(payload);
            return response;
        }

        public async Task<CancelSubscriptionResponseDto> CancelSubscriptionAsync(CancelSubscriptionRequestDto Request)
        {
            var result = await _httpClient.PostAsJsonAsync("request", Request);

            if (!result.IsSuccessStatusCode)
            {
                throw new Exception($"Error , code {result.StatusCode}");
            }
            var payload = await result.Content.ReadAsStringAsync();
            var response = JsonSerializer.Deserialize<CancelSubscriptionResponseDto>(payload);
            return response;
        }

        public async Task<SendFreeMTResponseDto> SendFreeMTAsync(SendFreeMTRequestDto Request)
        {
            var result = await _httpClient.PostAsJsonAsync("request", Request);

            if (!result.IsSuccessStatusCode)
            {
                throw new Exception($"Error , code {result.StatusCode}");
            }
            var payload = await result.Content.ReadAsStringAsync();
            var response = JsonSerializer.Deserialize<SendFreeMTResponseDto>(payload);
            return response;
        }
    }
}
