using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Name = "IService1")]
    public interface IService1change
    {

        [OperationContract]
        string GetMessage(string name);

   
    }
    //[ServiceContract]
    //public interface IService2
    //{

    //    [OperationContract]
    //    string GetConfidentialMessage(string name);


    //}
    //[ServiceContract]
    //public interface IService3
    //{

    //    [OperationContract]
    //    string GetPersonalMessage(string name);


    //}
}
