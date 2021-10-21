using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Transaction : Base
   {
        public char Type { get; set; }
        public string Status { get; set; }
        public decimal Amount { get; set; }
        public long SubscriptionId { get; set; }
        public int Key { get; set; }
    }
}
