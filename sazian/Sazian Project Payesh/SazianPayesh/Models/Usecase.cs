namespace SazianPayesh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usecase")]
    public partial class Usecase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usecase()
        {
            Activity = new HashSet<Activity>();
        }

        public int UseCaseId { get; set; }

        [StringLength(20)]
        public string UsecaseNo { get; set; }

        [StringLength(100)]
        public string UsecaseDS { get; set; }

        public int? ProjectId { get; set; }

        public bool? Enabled { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] Timestamp { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Activity> Activity { get; set; }

        public virtual Project Project { get; set; }
    }
}
