using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace footballcup.Models
{
    [Table("Team")]
    public class Team
    {
        [Key]
        public int TeamId { get; set; }

        [Required]
        [StringLength(40)]
        public string PName { get; set; }

        [Required]
        [StringLength(40)]
        public string LName { get; set; }

        [Display(Name = "حروف اختصاری")]
        public string con { get; set; }


        public int? oldid { get; set; }

    }
}