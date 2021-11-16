using System;
using System.ComponentModel.DataAnnotations;

namespace DTO.MW
{
    public class SendPinRequestDto
    {
        [System.Text.Json.Serialization.JsonPropertyName("action")]
        public string Action { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("msisdn")]
        public string Msisdn { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("productId")]
        public string ProductId { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("language")]
        public string Language { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("clientCorrelator")]
        public string ClientCorrelator { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("sourceIP")]
        public string SourceIp { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("pubId")]
        public string PubId { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("channel")]
        public string Channel { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("adPartnerName")]
        public string AdPartnerName { get; set; }

    }

    public class SendPinResponseDto
    {
        [System.Text.Json.Serialization.JsonPropertyName("responseDescription")]
        public ResponseDescription ResponseDescription { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("msisdn")]
        [Required(AllowEmptyStrings = false)]
        public string Msisdn { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("subscriptionId")]
        [Required]
        public long SubscriptionId { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("responseCode")]
        public int ResponseCode { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("transactionId")]
        [Required(AllowEmptyStrings = false)]
        public string TransactionId { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("errorMessage")]
        public string ErrorMessage { get; set; }

    }
}
