namespace DTO.MW
{
    public class CheckSubscriptionRequestDto
    {
        [System.Text.Json.Serialization.JsonPropertyName("action")]
        public string Action { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("msisdn")]
        public string Msisdn { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("productId")]
        public string ProductId { get; set; }

    }

    public class CheckSubscriptionResponseDto
    {
        [System.Text.Json.Serialization.JsonPropertyName("responseDescription")]
        public ResponseDescription ResponseDescription { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("msisdn")]
        public string Msisdn { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("subscriptionStatus")]
        public long SubscriptionId { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("errorMessage")]
        public string ErrorMessage { get; set; }

    }
}
