using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmdadMainServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IGuaranteeService" in both code and config file together.
    [ServiceContract]
    public interface IGuaranteeService
    {
        [OperationContract]
        string PostGuaranteeBadaneh(string strUserId, string strPassword, string strRequisition_Activity, string strRequisition_SparePart, string strDamageFinalRep);

        [OperationContract]
        string PostGuaranteeBadaneh2(string strUserId, string strPassword, DataSet dsRequisition_Activity, DataSet dsRequisition_SparePart, DataSet dsDamageFinalRep);
    }
}
