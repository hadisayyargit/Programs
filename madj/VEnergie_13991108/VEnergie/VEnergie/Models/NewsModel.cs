using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VEnergie.Models
{
    public class NewsModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Title is Required")]
        [MaxLength(145, ErrorMessage = "The number is unauthorized")]
        public string TITLE { get; set; }

        [Required(ErrorMessage = "Title is Required")]        
        public string NEWSTEXT { get; set; }

        public DateTime REGDATE { get; set; } 

        public int? VISIT { get; set; }


    }

}