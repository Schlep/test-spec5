using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spec5.Models
{
    public class EventCharity
    {
        public int EventCharityID { get; set; }
        public DateTime TimestampEntered { get; set; }
        public DateTime TimestampUpdated { get; set; }

        #region Foreign keys
        public int EventID { get; set; }
        public int CharityID { get; set; }
        #endregion

        public decimal DonationTarget { get; set; }
        public decimal DonationReceived { get; set; }

        #region Navigational properties
        public virtual Event Event { get; set; }
        public virtual Charity Charity { get; set; }
        #endregion
    }
}