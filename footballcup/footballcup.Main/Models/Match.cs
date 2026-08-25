using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace footballcup.Models
{
    [Table("Match")]
    public class Match
    {
        [Key]
        public int MatchId { get; set; }
        public byte MatchNo { get; set; }

        [Required]
        [Display(Name = "زمان بازی")]
        public DateTime MatchTime { get; set; }

        public int CupId { get; set; }
        public int Team1Id { get; set; }
        public int Team2Id { get; set; }
        public int? Team1Score { get; set; }
        public int? Team2Score { get; set; }

        [Display(Name = "مرحله/گروه")]
        public string GroupName { get; set; }

        [Display(Name = "ضریب امتیاز")]
        public int MatchCoefficient { get; set; }

        /// <summary>
        /// 0:شروع نشده(باز)
        /// 1:پایان یافته(بسته)
        /// 2:در حال بازی...
        /// </summary>
        [Display(Name = "وضعیت")]
        public byte MatchState { get; set; }

        public int UserId { get; set; }
        public DateTime ModifyTime { get; set; }
    }

    [NotMapped]
    public partial class MatchView:Match
    {
        public string Team1PName { get; set; }
        public string Team2PName { get; set; }

        public string con1 { get; set; }
        public string con2 { get; set; }
    }


}