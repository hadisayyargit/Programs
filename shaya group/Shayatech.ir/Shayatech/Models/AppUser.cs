using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shayatech.Models
{
    public class AppUser
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string UserDes { get; set; }

        [StringLength(100)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [StringLength(50)]
        public string UserImage { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public bool AllowWriteBlog { get; set; }
        public bool AllowWriteImage { get; set; }
        public bool HighPermission { get; set; }

    }
}
