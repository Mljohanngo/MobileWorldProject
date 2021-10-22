using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class MWSendFreeMT
   {
        public long SubscriptionId { get; set; }
        public string Action { get; set; }
        public string Msisdn { get; set; }
        public string BodyMessage { get; set; }
        public string ProductId { get; set; }
        public int HttpResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public int ResponseCode { get; set; }
        public string ResultMessage { get; set; }
    }
}
