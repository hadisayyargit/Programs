using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VEnergie.Models
{
    public class SendMailModel
    {
        [Display(Name = "Name")]
        [Required]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress), Display(Name = "Email")]
        [Required]
        public string FromEmail { get; set; }

        [Display(Name = "Body")]
        [DataType(DataType.MultilineText)]
        [Required]
        public string EMailBody { get; set; }

        [Display(Name = "Subject")]
        [MaxLength(30, ErrorMessage = "The number is unauthorized")]
        [Required]
        public string EmailSubject { get; set; }

    }
}