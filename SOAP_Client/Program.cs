using System;
using SOAP_Client.ServiceReference1;

namespace SOAP_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client();

            string first = "Road";
            string last = "Runner";
            string name = client.Greet(first, last);
            Console.WriteLine($"Greetings, {name}!");

            double miles = 106;
            double result = client.MilesToKM(miles);
            Console.WriteLine($"You just ran {result} kilometers!");

            Console.WriteLine("\nPress <Enter> to terminate the client");
            Console.ReadLine();
            client.Close();
        }
    }
}
