using System;

namespace SOAP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string Greet(string s1, string s2)
        {

            string name = s1 + " " + s2;

            Console.WriteLine($"Received Greet({s1}, {s2})");
            Console.WriteLine($"Return: {name}");

            return name;
        }

        public double MilesToKM(double d1)
        {
            double result = d1 * 1.609;

            Console.WriteLine($"Received MilesToKM({d1})");
            Console.WriteLine($"Return: {result}");

            return result;
        }
    }
}
