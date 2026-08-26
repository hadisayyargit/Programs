using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace quc.Models
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }

        [StringLength(100)]
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime PublishDate { get; set; }
        public Nullable<int> AuthorId { get; set; }

        [StringLength(50)]
        public string ImageName { get; set; }
        public bool IsActive { get; set; }
        public bool IsHotNews { get; set; }
        public bool IsQeshmNews { get; set; }



    }
}