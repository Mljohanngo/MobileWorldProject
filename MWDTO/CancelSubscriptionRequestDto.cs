namespace DTO.MW
{
    public class CancelSubscriptionRequestDto
    {
        public string Action { get; set; }
        public string Msisdn { get; set; }
        public long SubscriptionId { get; set; }
        public string Channel { get; set; }
        public string ProductId { get; set; }

    }

    public class CancelSubscriptionResponseDto
    {
        public ResponseDescription ResponseDescription { get; set; }
        public long SubscriptionId { get; set; }
        public int ResponseCode { get; set; }
        public string ErrorMessage { get; set; }

    }
}
