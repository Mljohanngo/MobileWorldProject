namespace DTO.MW
{
    public class SendFreeMTRequestDto
    {
        [System.Text.Json.Serialization.JsonPropertyName("action")]
        public string Action { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("msisdn")]
        public string Msisdn { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("messageBody")]
        public string MessageBody { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("productId")]
        public string ProductId { get; set; }

    }

    public class SendFreeMTResponseDto
    {
        [System.Text.Json.Serialization.JsonPropertyName("responseDescription")]
        public ResponseDescription ResponseDescription { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("responseCode")]
        public int ResponseCode { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("errorMessage")]
        public string ErrorMessage { get; set; }

    }
}
