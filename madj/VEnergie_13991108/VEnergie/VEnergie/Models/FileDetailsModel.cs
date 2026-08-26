using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VEnergie.Models
{
    public class FileDetailsModel
    {
        public int ID { get; set; }
        public int? MENUITEMID { get; set; }
        [Display(Name = "Uploaded File")]
        public string FILENAME { get; set; }
        public byte[] FILECONTENT { get; set; }
    }
}