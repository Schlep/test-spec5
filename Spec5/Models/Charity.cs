using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spec5.Models
{
    public class Charity
    {
        public int CharityID { get; set; }
        public DateTime TimestampEntered { get; set; }
        public DateTime TimestampUpdated { get; set; }

        public string CharityName { get; set; }
        public string Line1 { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string BankName { get; set; }
        public string BankBSB { get; set; }
        public string BankAccount { get; set; }
        public string ContactName1 { get; set; }
        public string ContactName2 { get; set; }
        public string Notes { get; set; }
        public bool Active { get; set; }

        #region Navigational properties
        public virtual IEnumerable<EventCharity> EventCharitys { get; set; }
        #endregion
    }
}