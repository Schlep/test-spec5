using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spec5.Models
{
    public class Event
    {
        public int EventID { get; set; }
        public DateTime TimestampEntered { get; set; }
        public DateTime TimestampUpdated { get; set; }

        public int EventNameCodeId { get; set; }
        public int CityCodeId { get; set; }
        public int StateCodeId { get; set; }
        public int CountryCodeId { get; set; }
        public int EventStatusId { get; set; }

        public int Distance { get; set; }
        public int Pitstops { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public DateTime RegistrationOpenDateTime { get; set; }
        public DateTime RegistrationCloseDateTime { get; set; }
        public DateTime DonationOpenDateTime { get; set; }
        public DateTime DonationCloseDateTime { get; set; }
        public string Notes { get; set; }
        public decimal RegistrationFeeAdult { get; set; }
        public decimal RegistrationFeeChild { get; set; }
        public decimal PledgeAdult { get; set; }
        public decimal PledgeChild { get; set; }

        #region Navigational properties
        public virtual IEnumerable<EventCharity> EventCharitys { get; set; }
        #endregion
    }
}