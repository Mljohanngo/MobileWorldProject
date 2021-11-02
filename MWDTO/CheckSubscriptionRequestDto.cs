namespace DTO.MW
{
    public class CheckSubscriptionRequestDto
    {
        public string Action { get; set; }
        public string Msisdn { get; set; }
        public string ProductId { get; set; }

    }

    public class CheckSubscriptionResponseDto
    {
        public ResponseDescription ResponseDescription { get; set; }
        public string Msisdn { get; set; }
        public long SubscriptionId { get; set; }
        public string ErrorMessage { get; set; }

    }
}
