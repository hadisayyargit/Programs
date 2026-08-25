using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace footballcup.Models
{
    [Table("Prediction")]
    public class Prediction
    {
        [Key]
        public int PredictId { get; set; }

        [Required]
        public int MatchId { get; set; }

        [Required]
        public int CompetitorId { get; set; }

        [Required]
        public DateTime PredictTime { get; set; }

        public int? Team1Guess { get; set; }
        public int? Team2Guess { get; set; }

        public bool ShowPrediction { get; set; }

        public int CompetitorMatchPoint { get; set; }

        [Required]
        public int UserId { get; set; }
        public DateTime ModifyTime { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] Timestamp { get; set; }
    
    }

    [NotMapped]
    public partial class PredictionView
    {
        public int? PredictId { get; set; }


        public int? MatchId { get; set; }


        public int? CompetitorId { get; set; }

        public int? UserId { get; set; }

        public int CupId { get; set; }
        public DateTime? PredictTime { get; set; }

        public int? Team1Guess { get; set; }
        public int? Team2Guess { get; set; }
        public byte? MatchNo { get; set; }
        public DateTime MatchTime { get; set; }
        public DateTime ModifyTime { get; set; }
        public DateTime? PredictModifyTime { get; set; }
        public int Team1Id { get; set; }
        public int Team2Id { get; set; }
        public string Team1PName { get; set; }
        public string Team2PName { get; set; }
        public byte[] CompetitorThumbnailPhoto { get; set; }
        public string CompetitorName { get; set; }
        public string con1 { get; set; }
        public string con2 { get; set; }
        public int? Team1Score { get; set; }
        public int? Team2Score { get; set; }
        public string GroupName { get; set; }
        public int MatchCoefficient { get; set; }
        public byte MatchState { get; set; }
        public bool ShowPrediction { get; set; }
        public string JPredictTime { get; set; }
        public string JMatchTime { get; set; }
        public string CupName { get; set; }

        public int UserRole { get; set; }

        public byte ParticipantType { get; set; }

        public int CompetitorMatchPoint { get; set; }

        public int TotalPredictionsPoint { get; set; }

        public int InitialPoint { get; set; }

        public int SpecialPoint { get; set; }

        public bool selected { get; set; }

        public string strJalali = "";
        public string imgsrc = "";

        public int GetCompetitorMatchPoint()
        {
            int res = 0;

            if (MatchState == 1 && CompetitorId>0)
            {
                if (Team1Score == Team1Guess && Team2Score == Team2Guess)
                {
                    res = 10 * (MatchCoefficient == 0 ? 1 : MatchCoefficient);
                }
                else
                {

                    ///شرکت در پیش‌بینی
                    res = 1;

                    ///نتیجه نسبی
                    if ((Team1Score == Team2Score && Team1Guess == Team2Guess) || (Team1Score > Team2Score && Team1Guess > Team2Guess) || (Team1Score < Team2Score && Team1Guess < Team2Guess))
                        res += 2;
                    /*
                    ///تفاضل گل
                    if (Team1Score - Team2Score == Team1Guess - Team2Guess)
                        res += 2;
                        */

                    ///تعداد گل تیم اول
                    if (Team1Score == Team1Guess)
                    {
                        if (Team1Score <= 3) res += 2;
                        else res += 4;
                    }
                    ///تعداد گل تیم دوم
                    if (Team2Score == Team2Guess)
                    {
                        if (Team2Score <= 3) res += 2;
                        else res += 4;
                    }

                    res = res * (MatchCoefficient == 0 ? 1 : MatchCoefficient);
                }
            }

            return res;
        }

        /*
    [NotMapped]
public partial class PredictionView:Prediction
{      
    public int CupId { get; set; }
    public byte? MatchNo { get; set; }
    public DateTime MatchTime { get; set; }
    public DateTime? PredictModifyTime { get; set; }
    public int Team1Id { get; set; }
    public int Team2Id { get; set; }
    public string Team1PName { get; set; }
    public string Team2PName { get; set; }
    public byte[] CompetitorThumbnailPhoto { get; set; }
    public string CompetitorName { get; set; }
    public string con1 { get; set; }
    public string con2 { get; set; }
    public int? Team1Score { get; set; }
    public int? Team2Score { get; set; }
    public string GroupName { get; set; }
    public int MatchCoefficient { get; set; }
    public byte MatchState { get; set; }

    public string JPredictTime { get; set; }
    public string JMatchTime { get; set; }
    public string CupName { get; set; }

    public int UserRole { get; set; }

    public byte ParticipantType { get; set; }

    public int TotalPredictionsPoint { get; set; }

    public int InitialPoint { get; set; }

    public int SpecialPoint { get; set; }

*/


    }


}