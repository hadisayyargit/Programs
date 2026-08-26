using System;
using System.ComponentModel.DataAnnotations;

namespace VEnergie.Models
{
    public class UserModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [MaxLength(50, ErrorMessage = "The number is unauthorized")]
        public string NAME { get; set; }

        [Required(ErrorMessage = "Family is Required")]
        [MaxLength(100, ErrorMessage = "The number is unauthorized")]
        public string FAMILY { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [DataType(DataType.Password)]
        public string PWD { get; set; }

        [Compare("PWD", ErrorMessage = "Please confirm your password")]
        [Required(ErrorMessage = "confirm Password is Required")]
        [DataType(DataType.Password)]
        public string ConfirmPWD { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string EMAIL { get; set; }

        public DateTime CREATEDDATE { get; set; }
        public DateTime LASTLOGINDATE { get; set; }
        public bool ISACTIVE { get; set; }
        public bool ISADMIN { get; set; }
       
    }
}