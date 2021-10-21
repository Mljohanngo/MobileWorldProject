using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class MWSendPin : Base
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
        public int HttpResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public long OpSubscriptionId { get; set; }

    }
}
