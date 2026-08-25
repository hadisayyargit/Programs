using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy.Models
{
    public enum UserRoleEnum
    {
        GUEST = 0
        , ADMIN = 1
    , MANAGER = 2
            , CLIENT = 3
    }

    [Table("AppUser")]
    public class AppUser
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        [Display(Name = "شناسه")]
        public int UserId { get; set; }

        [Display(Name = "نام شناسه ورود")]
        [Index(IsUnique = true)]
        [StringLength(50)]
        public string LoginName { get; set; }

        [Required(ErrorMessage = "نام کاربر الزامی است")]
        [Index(IsUnique = true)]
        [Display(Name = "نام کاربر")]
        [StringLength(50)]
        public string UserDs { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.Password)]
        [Display(Name = "گذرواژه")]
        public string Password { get; set; }

        [Index(IsUnique = true)]
        [Display(Name = "رایانامه")]
        [StringLength(100)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "شماره تلفن همراه")]
        [Index(IsUnique = true)]
        [StringLength(30)]
        //[Phone]
        public string Phone { get; set; }
        public int UserRole { get; set; }
        public byte[] ThumbnailPhoto { get; set; }

        public bool Enabled { get; set; }

        public string SchemaName { get; set; }

    }
}
