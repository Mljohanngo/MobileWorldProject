namespace DTO.MW
{
    public class ResponseDescription
    {
        [System.Text.Json.Serialization.JsonPropertyName("statusCode")]
        public int StatusCode { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("subscriptionId")]
        public string StatusMessage { get; set; }

    }
}
