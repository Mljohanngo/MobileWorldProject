using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Transaction : Base
   {
        public string TransactionId { get; set; }
        public string Msisdn { get; set; }  
        public int ProductId { get; set; }
        public string BillType { get; set; }
        public decimal BillAmount { get; set; }
        public string KeyWord { get; set; }
        public string Channel { get; set; }

    }
}
