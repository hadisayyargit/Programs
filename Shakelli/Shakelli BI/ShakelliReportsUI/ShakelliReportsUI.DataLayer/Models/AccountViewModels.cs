using System;
using System.ComponentModel.DataAnnotations;

namespace ShakelliReportsUI.DataLayer.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }
    }


    public class LoginViewModel
    {
        [Key]
        [Required(ErrorMessage = "شناسه کاربری الزامی است")]
        [Display(Name = "شناسه کاربری")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "گذرواژه الزامی است")]
        [DataType(DataType.Password)]
        [Display(Name = "گذرواژه")]
        public string Password { get; set; }

        [Display(Name = "مرا به یاد بسپار؟")]
        public bool RememberMe { get; set; }

        public string Message { get; set; }

    }

    public class ManageUserViewModel
    {
        [Display(Name = "شناسه")]
        public int UserId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} حداقل باید {2} کرکتر باشد.", MinimumLength = 3)]
        [DataType(DataType.Password)]
        [Display(Name = "رمز")]
        public string Password { get; set; }
        
        //[Required]
        [DataType(DataType.Password)]
        [Display(Name = "تکرار رمز")]
        [Compare("Password", ErrorMessage = "تکرار گذرواژه با گذرواژه مطابقت ندارد.")]
        public string ConfirmPassword { get; set; }

        public string Message { get; set; }

    }

    public class AppUserPersonView
    {
        public int UserId { get; set; }
        public Nullable<int> PersonId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Nullable<int> OrganizationId { get; set; }
        public string EnabledTitle { get; set; }
        public bool Enabled { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonCode { get; set; }
        public string NationalCode { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public byte[] Photo { get; set; }

        public string OrganizationTitle { get; set; }

        public Nullable<int> GroupId { get; set; }


    }

}
