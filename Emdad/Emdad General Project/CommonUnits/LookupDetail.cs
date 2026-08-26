using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonUnits
{
    public class LookupDetail
    {
        //PUB_LOOKUP_DETAIL
        public int id { get; set; }
        public string SYSCODE { get; set; }
        public short TBLCODE { get; set; }
        public string SUBCODE { get; set; }
        public string SUBNAME { get; set; }

    }

    public class PublicLookup
    {
        //PublicLookups
        public long id { get; set; }
        public string Title { get; set; }
        public int SystemCode { get; set; }
        public Nullable<long> ParentId { get; set; }
        public decimal PCode { get; set; }
        public string Rescode1 { get; set; }
        public string Rescode2 { get; set; }


    }
}
