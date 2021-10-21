using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Subscription : Base
   {
        public string Msisdn { get; set; }
        public int Key { get; set; }
        public string Status { get; set; }
        public DateTime CancelDate { get; set; }
        public DateTime LastRenew { get; set; }
        public DateTime NextRenew { get; set; }
        public DateTime LastSuccessfulRenew { get; set; }
        public int IdOperator { get; set; }
        public string EventSource { get; set; }
        public string ContentUrl { get; set; }
    }
}
