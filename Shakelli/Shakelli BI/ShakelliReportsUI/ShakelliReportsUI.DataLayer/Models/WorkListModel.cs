using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace ShakelliReportsUI.DataLayer.Models
{
    public class WorkListModel
    {
        [Key]
        public decimal ItemId { get; set; }

        public string ItemDs { get; set; }
        
        public string ItemName { get; set; }

        public string ItemClass { get; set; }
        public bool HasDirectPath { get; set; }
        public bool HasOwnGrid { get; set; }
        public bool HasServerReport { get; set; }

        public string UrlPath { get; set; }


    }


}