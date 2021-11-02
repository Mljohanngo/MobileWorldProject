namespace DTO.MW
{
    public class ResendPinRequestDto
    {
        public string Action { get; set; }
        public long SubscriptionId { get; set; }
        public string ProductId { get; set; }

    }
    public class ResendPinResponseDto
    {
        public ResponseDescription ResponseDescription { get; set; }
        public long SubscriptionId { get; set; }
        public int ResponseCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}
