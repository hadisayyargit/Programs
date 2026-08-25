using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace footballcup.Models
{
    [Table("CupTeam")]
    public class CupTeam
    {
        [Key]
        public int Id { get; set; }
        public int CupId { get; set; }
        public int TeamId { get; set; }

        public int TeamRank { get; set; }
    }


    [NotMapped]
    public partial class CupTeamView : CupTeam
    {
        public string TeamPName { get; set; }
        public string TeamLName { get; set; }
        public string CupPName { get; set; }
        public string con { get; set; }
        public bool selected { get; set; }
        public CupTeamView()
        {

        }

        public CupTeamView(CupTeam a)
        {
            this.Id = a.Id;
            this.CupId = a.CupId;
            this.TeamId = a.TeamId;
            this.TeamRank = a.TeamRank;
        }

    }



}