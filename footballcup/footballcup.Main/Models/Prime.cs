
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

namespace footballcup.Models
{
    /*
    [Table("Prime", Schema="basic")]
        */

    [Table("basic.Prime")]
    public partial class Prime
    {
        public decimal Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(100)]
        public string ETitle { get; set; }

        public int? PCode { get; set; }

        public decimal? ParentId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] Timestamp { get; set; }
    }
}
