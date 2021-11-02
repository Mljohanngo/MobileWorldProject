using System;

namespace DTO.MW
{
    public class SendPinRequestDto
    {
        public string Action { get; set; }
        public string Msisdn { get; set; }
        public string ProductId { get; set; }
        public string Language { get; set; }
        public string ClientCorrelator { get; set; }
        public string SourceIp { get; set; }
        public string PubId { get; set; }
        public string Channel { get; set; }
        public string AdPartnerName { get; set; }

    }

    public class SendPinResponseDto
    {
        public ResponseDescription ResponseDescription { get; set; }
        public string Msisdn { get; set; }
        public long SubscriptionId { get; set; }
        public int ResponseCode { get; set; }
        public string TransactionId { get; set; }
        public string ErrorMessage { get; set; }

    }

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

    public class ResponseDescription
    {
        public int StatusCode { get; set; }
        public string StatusMessage { get; set; }

    }
}
