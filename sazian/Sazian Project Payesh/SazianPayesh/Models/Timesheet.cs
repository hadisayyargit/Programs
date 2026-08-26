namespace SazianPayesh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Timesheet")]
    public partial class Timesheet
    {
        public int TimeSheetId { get; set; }

        public DateTime? TDate { get; set; }

        public DateTime? BeginTime { get; set; }

        public DateTime? EndTime { get; set; }

        public int? PersonId { get; set; }

        public bool? Enabled { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] Timestamp { get; set; }
    }
}
