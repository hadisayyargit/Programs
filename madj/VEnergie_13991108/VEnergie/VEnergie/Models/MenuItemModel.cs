using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VEnergie.Models
{
    public class MenuItemModel
    {
        [Required(ErrorMessage = "Page is Required")]     
        public int ID { get; set; }

        [Required(ErrorMessage = "Title is Required")]
        [MaxLength(49, ErrorMessage = "The number is unauthorized")]
        public string MENU { get; set; }

        public string HANDLER { get; set; }
        public int PARENTID { get; set; }
        [AllowHtml]
        public string MTEXT { get; set; }
        public bool MNUSEEN { get; set; }
    }
}