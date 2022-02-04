using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Affiliates
{
    public class AffiliateDto
    {
        // Affiliate Campaign Id
        [Required(ErrorMessage = "The Id Campaign is required")]
        public int Mip_Prt { get; set; }
        [Required(ErrorMessage = "The Transaction Id is required")]
        // Affiliate Pixel (Unique Transaction Id)
        public string Mip_Afc { get; set; }

        public long Id_Hit { get; set; }

        public string Ip_Address { get; set; }

    }
}
