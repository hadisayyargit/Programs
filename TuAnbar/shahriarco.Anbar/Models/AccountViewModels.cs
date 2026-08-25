using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace shahriarco.Anbar.Models
{



    //public class VerifyCodeViewModel
    //{
    //    [Required]
    //    public string Provider { get; set; }

    //    [Required]
    //    [Display(Name = "Code")]
    //    public string Code { get; set; }
    //    public string ReturnUrl { get; set; }

    //    [Display(Name = "Remember this browser?")]
    //    public bool RememberBrowser { get; set; }

    //    public bool RememberMe { get; set; }
    //}


    public class LoginViewModel
    {


        [Display(Name = "UserId")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "شناسه کاربری الزامی است")]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "گذرواژه الزامی است")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

    }



}
