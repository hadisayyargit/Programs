using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;

namespace VEnergie.Models
{
    public class VEnergieDbContext : DbContext
    {
        public VEnergieDbContext() :
           base("name=msafdariEntities")

        {
        }


        public DbSet<UserProfileModel> USERPROFILE { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
       
    }
}