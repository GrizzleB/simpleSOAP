using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using SOAP;

namespace SOAP_Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8733/SOAP/");
            ServiceHost selfHost = new ServiceHost(typeof(Service1), baseAddress);

            try
            {
                selfHost.AddServiceEndpoint(typeof(IService1), new WSHttpBinding(), "Service1");

                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);

                selfHost.Open();
                Console.WriteLine("The {0} service is ready", "Service1");

                Console.WriteLine("Press <Enter> to terminate the service.");
                Console.WriteLine();
                Console.ReadLine();
                selfHost.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("An exception occurred: {0}", ce.Message);
                selfHost.Abort();
            }

        }
    }
}
