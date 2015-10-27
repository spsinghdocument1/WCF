using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;


namespace Interface
{
    [ServiceContract]
    public interface IService1
    {


       [WebGet(UriTemplate = "Employee", ResponseFormat = WebMessageFormat.Json)]
      //   [WebInvoke(Method = "GET",RequestFormat = WebMessageFormat.Json,ResponseFormat = WebMessageFormat.Json,BodyStyle = WebMessageBodyStyle.Wrapped,UriTemplate = "Employee")]
      
        [OperationContract]
      string GetData2();


    }
}
