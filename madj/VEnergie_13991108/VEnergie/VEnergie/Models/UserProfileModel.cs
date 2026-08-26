using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Web;

namespace VEnergie.Models
{ 
    public partial class UserProfileModel
    {
        [Key]
        public int UserId { get; set; }
        public string BgColor { get; set; }
        public string IconFile { get; set; }
        public string FontFamily { get; set; }
        public string FontSize { get; set; }
    }
}
