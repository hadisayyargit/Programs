namespace SazianPayesh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JobTask")]
    public partial class JobTask
    {
        [Key]
        public int TaskId { get; set; }

        [Required]
        [StringLength(20)]
        public string wbs { get; set; }

        public int PersonId { get; set; }

        public DateTime TaskDate { get; set; }

        public int ActivityId { get; set; }

        public int TaskDuration { get; set; }

        [StringLength(100)]
        public string TaskDs { get; set; }

        public bool? Enabled { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] Timestamp { get; set; }

        public virtual Activity Activity { get; set; }

        public virtual Person Person { get; set; }
    }
}
