namespace DTO.MW
{
    public class ConfirmPinRequestDto
    {
        public string Action { get; set; }
        public string Msisdn { get; set; }
        public long SubscriptionId { get; set; }
        public string PinCode { get; set; }
        public string TransactionId { get; set; }
        public string ProductId { get; set; }
        public string SourceIp { get; set; }
        public string PubId { get; set; }
        public string Channel { get; set; }
        public string AdPartnerName { get; set; }

    }

    public class ConfirmPinResponseDto
    {
        public ResponseDescription ResponseDescription { get; set; }
        public string Msisdn { get; set; }
        public long SubscriptionId { get; set; }
        public int ResponseCode { get; set; }
        public string ErrorMessage { get; set; }
        public int PaymentStatus { get; set; }

    }

}
