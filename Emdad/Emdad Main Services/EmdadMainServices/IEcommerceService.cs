using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmdadMainServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEcommerceService" in both code and config file together.
    [ServiceContract]
    public interface IEcommerceService
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/EcommerceService/{id}?format=json")]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        //[WebGet(UriTemplate = "/EcommerceService/{id}")] 
        DataSet GetFinalPrice(string strUserId, string strPassword);

        [OperationContract]
        DataSet GetServices(string strUserId, string strPassword);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/EcommerceService/{strUserId}")]
        string SubmitInvoice(string strUserId, string strPassword, string xmlInvoice);
        // TODO: Add your service operations here


    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "EmdadEcommerceServices.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
