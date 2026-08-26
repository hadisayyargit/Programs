using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace quc.Models
{
    public class AppUser
    {
        [Key]
        public int UserId { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string UserDes { get; set; }

        [StringLength(100)]
        public string Password { get; set; }

        [StringLength(50)]
        public string UserImage { get; set; }
        public Nullable<bool> IsActive { get; set; }

        public bool AllowWriteBlog { get; set; }
        public bool AllowWriteImage { get; set; }


    }
}