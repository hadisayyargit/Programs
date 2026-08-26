namespace SazianPayesh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Person")]
    public partial class Person
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Person()
        {
            JobTask = new HashSet<JobTask>();
            ProjectPersonRole = new HashSet<ProjectPersonRole>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PersonId { get; set; }

        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30)]
        public string LastName { get; set; }

        public bool? Gender { get; set; }

        [StringLength(10)]
        public string NationalCode { get; set; }

        public byte? MaritalStatus { get; set; }

        public byte? EducationDegree { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        public DateTime? BirthDate { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        public byte[] ThumbNailPhoto { get; set; }

        [StringLength(50)]
        public string ThumbnailPhotoFileName { get; set; }

        [StringLength(300)]
        public string Address { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] Timestamp { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobTask> JobTask { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectPersonRole> ProjectPersonRole { get; set; }
    }
}
