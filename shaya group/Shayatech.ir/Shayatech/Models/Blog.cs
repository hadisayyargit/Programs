using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shayatech.Models
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }

        [StringLength(100)]
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime PublishDate { get; set; }
        public int AuthorId { get; set; }

        [StringLength(100)]
        public string ImageName { get; set; }

        [StringLength(50)]
        public string AutorName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string AutorEmail { get; set; }
        public bool IsActive { get; set; }
        public bool IsNews { get; set; }
        public bool IsHotNews { get; set; }

        public Nullable<int> ParentBlogId { get; set; }

        /// <summary>
        /// 0: Nothing; 1:Like; 2:Dislike
        /// </summary>
        public Nullable<short> ParentLike { get; set; }
    }
}