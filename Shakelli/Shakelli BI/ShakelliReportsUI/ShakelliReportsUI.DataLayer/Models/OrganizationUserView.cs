using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShakelliReportsUI.DataLayer.Models
{
    public class OrganizationUserView
    {
        public int Id { get; set; }
        public Nullable<int> OrganizationId { get; set; }
        public Nullable<int> UserId { get; set; }
        public string Title { get; set; }

        public Nullable<int> ParentId { get; set; }
        public Nullable<int> OrganizationTypeCode { get; set; }

        public string LocationCode { get; set; }
        public string AutorizeCode { get; set; }

        public string OrganizationTypeCodeDs { get; set; }

        public string ParentOrganizationDs { get; set; }

        public string UserName { get; set; }


    }


}