using Spec5.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Spec5.DAL
{
    public class ExtraMileInitializer : DropCreateDatabaseIfModelChanges<ExtraMileContext>
    {
        protected override void Seed(ExtraMileContext context)
        {
            SeedCharity(context);
            SeedEvent(context);
            context.SaveChanges();
        }

        private static void SeedCharity(Spec.DAL.ExtraMileContext context)
        {
            var charitys = new List<Charity>
            {
                new Charity
                {
                    Active = true,
                    BankAccount = "12345678",
                    BankBSB = "123456",
                    BankName = "Bank Name",
                    CharityName = "Charity Name",
                    ContactName1 = "Contact Name 1",
                    ContactName2 = "Contact Name 2",
                    Country = "Australia",
                    Email = "email@charity.com",
                    Line1 = "Line1",
                    Notes = "Notes",
                    Phone = "0312345678",
                    Postcode = "3000",
                    State = "State",
                    Suburb = "Suburb",
                    TimestampEntered = DateTime.Now,
                    TimestampUpdated = DateTime.Now,
                    Website = "Website"
                }
            };

            charitys.ForEach(c => context.Charitys.Add(c));
        }

        private static void SeedEvent(Spec.DAL.ExtraMileContext context)
        {
            var events = new List<Event>
            {
                new Event
                {
                    CityCodeId = 0,
                    CountryCodeId = 0,
                    Distance = 42,
                    DonationCloseDateTime = DateTime.Now,
                    DonationOpenDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now,
                    EventNameCodeId = 0,
                    EventStatusId = 0,
                    Notes = "Notes",
                    Pitstops = 2,
                    PledgeAdult = 42,
                    PledgeChild = 21,
                    RegistrationCloseDateTime = DateTime.Now,
                    RegistrationFeeAdult = 42,
                    RegistrationFeeChild = 21,
                    RegistrationOpenDateTime = DateTime.Now,
                    StartDateTime = DateTime.Now,
                    StateCodeId = 0,
                    TimestampEntered = DateTime.Now,
                    TimestampUpdated = DateTime.Now
                }
            };

            events.ForEach(e => context.Events.Add(e));
        }
    }
}