using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace footballcup.Models
{    

    [Table("Competitor")]
    public class Competitor
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CupId { get; set; }
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CompetitorId { get; set; }
        public DateTime RegDate { get; set; }
        public byte RegStatus { get; set; }

        public byte ParticipantType { get; set; }
        ///1:شرکت‌کننده حقیقی
        ///0:شرکت‌کننده مجازی      

        public int TotalPredictionsPoint { get; set; }

        public int InitialPoint { get; set; }

        public int SpecialPoint { get; set; }

        [Required]
        public DateTime PredictDate { get; set; }

        public int? Team1 { get; set; }
        public int? Team2 { get; set; }
        public int? Team3 { get; set; }
        public DateTime ModifyTime { get; set; }
        public Competitor()
        {

        }

        public Competitor(CompetitorView derrived)
        {
            this.CupId = derrived.CupId;
            this.CompetitorId = derrived.CompetitorId;
            this.InitialPoint = derrived.InitialPoint;
            this.SpecialPoint = derrived.SpecialPoint;
            this.TotalPredictionsPoint = derrived.TotalPredictionsPoint;
            this.RegDate = derrived.RegDate;
            this.RegStatus = derrived.RegStatus;
            this.PredictDate = derrived.PredictDate;
            this.ParticipantType = derrived.ParticipantType;
            this.Team1 = derrived.Team1;
            this.Team2 = derrived.Team2;
            this.Team3 = derrived.Team3;
            this.ModifyTime = derrived.ModifyTime;
        }

        public int GetTotalCompetitorMatchPoint()
        {
            footballcupDbContext db = new footballcupDbContext();

            int res = 0;

            List<Prediction> myPredictionList = (from p in db.Prediction
                                                 join m in db.Match on p.MatchId equals m.MatchId
                                                 where m.CupId == CupId

                                                 select p

                                           ).Where(p => p.CompetitorId == CompetitorId).ToList();

            res = myPredictionList.Sum(p => p.CompetitorMatchPoint);


            return res;
        }

        public int GetCompetitorPredictionChampionPoint()
        {
            footballcupDbContext db = new footballcupDbContext();

            int res = 0;

            Cup myCup = db.Cup.Where(m => m.CupId == CupId).FirstOrDefault();

                if (this.Team1 == myCup.Team1 && myCup.Team1 != 0 && myCup.Team1 != null) res += 10;
                if (this.Team2 == myCup.Team2 && myCup.Team2 != 0 && myCup.Team2 != null) res += 6;
                if (this.Team3 == myCup.Team3 && myCup.Team3 != 0 && myCup.Team3 != null) res += 4;
            

            return res;
        }

    }



    [NotMapped]
    public partial class CompetitorView : Competitor
    {
        public string LoginName { get; set; }
        public string CupPName { get; set; }
        public string CompetitorName { get; set; }

        public int UserRole { get; set; }
        public byte[] ThumbnailPhoto { get; set; }

        public bool selected { get; set; }
        public string Team1PName { get; set; }
        public string Team2PName { get; set; }
        public string Team3PName { get; set; }

        public int Team1Rank { get; set; }
        public int Team2Rank { get; set; }
        public int Team3Rank { get; set; }

        public string Team1con { get; set; }
        public string Team2con { get; set; }
        public string Team3con { get; set; }

        public Int64 CompetitorRank { get; set; }

        public CompetitorView()
        {

        }

        public CompetitorView(Competitor a)
        {
            this.CupId = a.CupId;
            this.CompetitorId = a.CompetitorId;
            this.RegDate = a.RegDate;
            this.RegStatus = a.RegStatus;
            this.ParticipantType = a.ParticipantType;

            this.TotalPredictionsPoint = a.TotalPredictionsPoint;
            this.InitialPoint = a.InitialPoint;
            this.SpecialPoint = a.SpecialPoint;
            this.PredictDate = a.PredictDate;
            this.Team1 = a.Team1;
            this.Team2 = a.Team2;
            this.Team3 = a.Team3;
            this.ModifyTime = a.ModifyTime;

        }



    }

}