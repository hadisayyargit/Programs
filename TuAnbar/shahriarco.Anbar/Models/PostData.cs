using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace shahriarco.Anbar.Models
{
    public class PostData
    {
        [Display(Name = "ردیف")]
        public Int32 RowNo { get; set; }
        public string column1Name { get; set; }
        public string column1Value { get; set; }
        public string column1Type { get; set; }

        public string column2Name { get; set; }
        public string column2Value { get; set; }
        public string column2Type { get; set; }

        public string column3 { get; set; }

    }


}