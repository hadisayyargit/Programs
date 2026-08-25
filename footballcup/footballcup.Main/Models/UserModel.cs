namespace footballcup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    public enum UserRoleEnum
    {
        GUEST = 0                   ///مهمان
        , PARTICIPANT = 1           ///شرکت‌کننده         
        , ADMIN = 2                 ///راهبر سامانه
        
    }


    [Table("AppUser")]
    public partial class AppUser
    {
        [Key]
        [Required]
        [Display(Name = "شناسه")]
        public int UserId { get; set; }

        [Display(Name = "نام شناسه ورود")]
        [Index(IsUnique = true)]
        [StringLength(50)]
        public string LoginName { get; set; }

        [Index(IsUnique = true)]
        [Display(Name = "رایانامه")]
        [StringLength(100)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "شماره تلفن همراه")]
        [Index(IsUnique = true)]
        [StringLength(50)]
        //[Phone]
        public string Phone { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.Password)]
        [Display(Name = "گذرواژه")]
        public string Password { get; set; }

        [Required(ErrorMessage = "نام کاربر الزامی است")]
        [Index(IsUnique = true)]
        [Display(Name = "نام کاربر")]
        [StringLength(50)]
        public string UserDs { get; set; }

        public int UserRole { get; set; }
        public byte[] ThumbnailPhoto { get; set; }

        public bool Enabled { get; set; }

    }

    [NotMapped]
    public partial class AppUserView : AppUser
    {
        [DataType(DataType.Password)]
        [Display(Name = "تکرار گذرواژه")]
        [Compare("Password", ErrorMessage = "رمز ورود و تکرار آن یکسان نیستند!")]
        public string ConfirmPassword { get; set; }

        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        public string ThumbnailPhotoFileName { get; set; }

        /// <summary>
        /// بدلیل احتیاج به دو overload باید پایین را هم بدهیم 
        /// </summary>
        public AppUserView()
        {
        }

        public AppUserView(AppUser a)
        {
            this.UserId = a.UserId;
            this.UserDs = a.UserDs;
            this.Phone = a.Phone;
            this.Password = a.Password;
            this.LoginName = a.LoginName;
            this.Enabled = a.Enabled;
            this.Email = a.Email;
            this.ThumbnailPhoto = a.ThumbnailPhoto;
            this.UserRole = a.UserRole;
        }

    }

}
