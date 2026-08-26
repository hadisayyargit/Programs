using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShakelliReportsUI.DataLayer.Models
{
    public class AppGroupUserObjectView
    {
        public int Id { get; set; }
        public int ObjectId { get; set; }
        public string ObjectName { get; set; }
        public string ObjectDs { get; set; }
        public Nullable<int> ParentObjectId { get; set; }
        public Nullable<int> ObjectTypeCode { get; set; }

        public string ObjectTypeDs { get; set; }

        public string ParentObjectDs { get; set; }

        public Nullable<int> GroupId { get; set; }
        public Nullable<int> UserId { get; set; }
        public string CRUD { get; set; }

        public bool CreateRight { get; set; }
        public bool ReadRight { get; set; }
        public bool UpdateRight { get; set; }
        public bool DeleteRight { get; set; }

        public string UserName { get; set; }

        public string GroupName { get; set; }

        public bool HasDirectPath { get; set; }
        public bool HasOwnGrid { get; set; }
        public bool HasServerReport { get; set; }

        public string UrlPath { get; set; }

    }


}