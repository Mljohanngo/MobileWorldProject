using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class MWConfirmPin
   {
        public long SubscriptionId { get; set; }
        public string Action { get; set; }
        public string Msisdn { get; set; }
        public string OpSubscriptionId { get; set; }
        public string PinCode { get; set; }
        public string TransactionId { get; set; }
        public string ProductId { get; set; }
        public string SourceIp { get; set; }
        public string PubId { get; set; }
        public string Channel { get; set; }
        public string AdPartnerName { get; set; }
        public int HttpResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public int ResponseCode { get; set; }
        public string TrxID { get; set; }
        public string ErrorMessage { get; set; }
        public int PaymentStatus { get; set; }


    }
}
