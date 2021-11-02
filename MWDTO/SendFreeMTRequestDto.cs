namespace DTO.MW
{
    public class SendFreeMTRequestDto
    {
        public string Action { get; set; }
        public string Msisdn { get; set; }
        public string MessageBody { get; set; }
        public string ProductId { get; set; }

    }

    public class SendFreeMTResponseDto
    {
        public ResponseDescription ResponseDescription { get; set; }
        public int ResponseCode { get; set; }
        public string ErrorMessage { get; set; }

    }
}
