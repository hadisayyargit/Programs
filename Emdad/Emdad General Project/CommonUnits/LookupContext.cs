using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;

namespace CommonUnits
{
    public class LookupContext : DbContext

    {
        public DbSet<PublicLookup> PublicLookups { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PublicLookup>().ToTable("PublicLookups");


            Database.SetInitializer<LookupContext>(null);

            base.OnModelCreating(modelBuilder);
        }
    }

    
}
