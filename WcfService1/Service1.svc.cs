using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1change
        //,IService2,IService3
    {
        //public string GetConfidentialMessage(string name)
        //{
        //    return "Hello confidential - " + name;
        //}

        public string GetMessage(string name)
        {
            return "Hello - " + name;
        }

        //public string GetPersonalMessage(string name)
        //{
        //    return "Hello Personal- " + name;
        //}
    }
}
