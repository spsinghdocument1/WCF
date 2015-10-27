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
 public   interface Iadmin
    {


        [WebGet(UriTemplate = "Employee1", ResponseFormat = WebMessageFormat.Json)]
        //   [WebInvoke(Method = "GET",RequestFormat = WebMessageFormat.Json,ResponseFormat = WebMessageFormat.Json,BodyStyle = WebMessageBodyStyle.Wrapped,UriTemplate = "Employee")]

        [OperationContract]
        string name();
        [WebGet(UriTemplate = "Employeework", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        string work();

    }
}
