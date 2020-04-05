using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using HelloServiceHost;

namespace HelloServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(WcfService1.Service1))) 
            {
                host.Open();
                Console.WriteLine("Service has been started @ " + DateTime.Now);
                Console.ReadLine();
            }
        }
    }
}
