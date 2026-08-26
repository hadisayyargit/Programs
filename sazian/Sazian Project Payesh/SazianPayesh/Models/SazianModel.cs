namespace SazianPayesh.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SazianModel : DbContext
    {
        public SazianModel()
            : base("name=LocalConnection")
        //: base("name=SazianEntities")
        {
        }

        public virtual DbSet<Prime> Prime { get; set; }
        public virtual DbSet<Activity> Activity { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<JobTask> JobTask { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<ProjectPersonRole> ProjectPersonRole { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Timesheet> Timesheet { get; set; }
        public virtual DbSet<Usecase> Usecase { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Prime>()
                .Property(e => e.Id)
                .HasPrecision(8, 3);

            modelBuilder.Entity<Prime>()
                .Property(e => e.ETitle)
                .IsUnicode(false);

            modelBuilder.Entity<Prime>()
                .Property(e => e.ParentId)
                .HasPrecision(8, 3);

            modelBuilder.Entity<Prime>()
                .Property(e => e.Timestamp)
                .IsFixedLength();

            modelBuilder.Entity<Activity>()
                .Property(e => e.ActivityNo)
                .IsUnicode(false);

            modelBuilder.Entity<Activity>()
                .Property(e => e.Timestamp)
                .IsFixedLength();

            modelBuilder.Entity<Activity>()
                .HasMany(e => e.JobTask)
                .WithRequired(e => e.Activity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.DepartmentNo)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.Timestamp)
                .IsFixedLength();

            modelBuilder.Entity<JobTask>()
                .Property(e => e.wbs)
                .IsUnicode(false);

            modelBuilder.Entity<JobTask>()
                .Property(e => e.Timestamp)
                .IsFixedLength();

            modelBuilder.Entity<Person>()
                .Property(e => e.NationalCode)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Timestamp)
                .IsFixedLength();

            modelBuilder.Entity<Person>()
                .HasMany(e => e.JobTask)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Project>()
                .Property(e => e.Timestamp)
                .IsFixedLength();

            modelBuilder.Entity<ProjectPersonRole>()
                .Property(e => e.Timestamp)
                .IsFixedLength();

            modelBuilder.Entity<Role>()
                .Property(e => e.Timestamp)
                .IsFixedLength();

            modelBuilder.Entity<Timesheet>()
                .Property(e => e.Timestamp)
                .IsFixedLength();

            modelBuilder.Entity<Usecase>()
                .Property(e => e.UsecaseNo)
                .IsUnicode(false);

            modelBuilder.Entity<Usecase>()
                .Property(e => e.Timestamp)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .Property(e => e.UserNo)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Timestamp)
                .IsFixedLength();
        }
    }
}
