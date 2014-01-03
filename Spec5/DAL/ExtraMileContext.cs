using Spec5.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Spec5.DAL
{
    public class ExtraMileContext : DbContext
    {
        public ExtraMileContext() : base("ExtraMileContext")
        {

        }

        public DbSet<Charity> Charitys { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventCharity> EventCharitys { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}