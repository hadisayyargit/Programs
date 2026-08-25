using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pharmacy.Models
{
    public class Cms
    {
        [Key]
        public int CmsId { get; set; }

        [StringLength(100)]
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime? PublishDate { get; set; }

        public Nullable<int> ParentCmsId { get; set; }

        [StringLength(100)]
        public string ImageName { get; set; }
        public string PictureFile { get; set; }
        public int? AuthorId { get; set; }
        public string AutorName { get; set; }
        public string AutorEmail { get; set; }
        public bool IsActive { get; set; }

        /// <summary>
        /// True: Chat ,Opinion ,ViewPoint
        /// False: News ,Blog   
        /// </summary>
        public bool IsChat { get; set; }
        public bool IsHotNews { get; set; }
        public bool IsSlider { get; set; }
        public byte? LikeDislike { get; set; }

        public string SchemaName { get; set; }

    }
}