namespace SazianPayesh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProjectPersonRole")]
    public partial class ProjectPersonRole
    {
        public int Id { get; set; }

        public int? RoleId { get; set; }

        public int? PersonId { get; set; }

        public int? ProjectId { get; set; }

        public int? DepartmentId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] Timestamp { get; set; }

        public bool? Enabled { get; set; }

        public virtual Department Department { get; set; }

        public virtual Person Person { get; set; }

        public virtual Role Role { get; set; }
    }
}
