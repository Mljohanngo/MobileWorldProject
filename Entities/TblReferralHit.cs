using System;
using System.Collections.Generic;


namespace Entities
{
    public partial class TblReferralHit
    {
        public long IdHit { get; set; }
        public long IdCampaign { get; set; }
        public string TransactionId { get; set; }
        public string Msisdn { get; set; }
        public DateTime CreateDate { get; set; }
        public string IpAddress { get; set; }
        public string UserAgent { get; set; }
        public string Promo { get; set; }
    }
}
