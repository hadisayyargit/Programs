namespace SazianPayesh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Activity")]
    public partial class Activity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Activity()
        {
            JobTask = new HashSet<JobTask>();
        }

        public int ActivityId { get; set; }

        [StringLength(20)]
        public string ActivityNo { get; set; }

        [StringLength(100)]
        public string ActivityDs { get; set; }

        public int? UsecaseId { get; set; }

        //public int? ParentActivityId { get; set; }
        public bool? Enabled { get; set; }

        public int? ActivityTypeId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] Timestamp { get; set; }

        public virtual Usecase Usecase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobTask> JobTask { get; set; }
    }
}
