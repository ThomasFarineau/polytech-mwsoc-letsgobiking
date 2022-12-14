using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Description;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace LetsGoBikingServer
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var httpUrl = new Uri("http://localhost:8733/Design_Time_Addresses/LetsGoBikingServer/ILetsGoBiking");
            var Host = new ServiceHost(typeof(LetsGoBiking), httpUrl);

            Host.AddServiceEndpoint(typeof(ILetsGoBiking), new BasicHttpBinding(), "");

           

            var smb = new ServiceMetadataBehavior
            {
                HttpGetEnabled = true,
                HttpsGetEnabled = true,
            };
            Host.Description.Behaviors.Add(smb);
            Host.Open();


            Console.WriteLine("LetsGoBikingServer is running");
            Console.WriteLine("Press <Enter> key to exit" + Environment.NewLine);
            Console.ReadLine();
        }
    }
}
