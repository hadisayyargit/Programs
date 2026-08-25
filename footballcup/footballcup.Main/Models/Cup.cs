namespace footballcup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    [Table("Cup")]
    public class Cup
    {
        [Key]
        public int CupId { get; set; }

        [Required]
        [Index(IsUnique =true) ]
        [StringLength(60)]
        [Display(Name = "عنوان لاتین")]
        public string LName { get; set; }

        [Display(Name = "عنوان پارسی")]
        public string PName { get; set; }

        public string PhotoFileName { get; set; }

        public DateTime CupDate { get; set; }

        public bool IsDefaultCup { get; set; }

        public bool Enabled { get; set; }

        public int? Team1 { get; set; }
        public int? Team2 { get; set; }
        public int? Team3 { get; set; }

        public DateTime PredictionDueTime { get; set; }
    }
}
