using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Product : Base
   {
        public int Key { get; set; }
        public string AppName { get; set; }
        public string ServiceName { get; set; }
        public bool IsActive { get; set; }
        public long PartnerId { get; set; }
    }
}
