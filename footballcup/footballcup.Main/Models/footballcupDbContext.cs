namespace footballcup.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class footballcupDbContext : DbContext
    {
        public footballcupDbContext() : 
            base("name=DefaultConnection")
             
        {
        }

        public virtual DbSet<Prime> Prime { get; set; }
        public virtual DbSet<AppUser> AppUser { get; set; }
        public virtual DbSet<Cms> Cms { get; set; }
        public virtual DbSet<Cup> Cup { get; set; }
        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<Match> Match { get; set; }
        public virtual DbSet<Prediction> Prediction { get; set; }
        public virtual DbSet<CupTeam> CupTeam { get; set; }
        public virtual DbSet<Competitor> Competitor { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
