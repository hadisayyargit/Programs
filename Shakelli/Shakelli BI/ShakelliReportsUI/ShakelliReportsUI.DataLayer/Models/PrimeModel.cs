using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace ShakelliReportsUI.DataLayer.Models
{
    public class PrimeModel
    {
        [Key]
        [Display(Name="شناسه")]
        [Required(ErrorMessage = "شناسه الزامی است")]
        public int PrimeId { get; set; }

        [Display(Name = "عنوان")]
        public string PrimeDs { get; set; }
        [Display(Name = "کد")]
        public decimal PrimeCode { get; set; }
        [Display(Name = "سیستم")]
        public int SystemCode { get; set; }
        public Nullable<int> ParentId { get; set; }

        /*
            [DataType(DataType.Date, ErrorMessage = "قالب تاریخ صحیح نمی باشد")]         
            
            [Display(Name = "پست الکترونیکی")]
            [DataType(DataType.EmailAddress)]
            [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "پست الکترونیک معتبر نیست")]
         * 
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
          
         */
    }


}