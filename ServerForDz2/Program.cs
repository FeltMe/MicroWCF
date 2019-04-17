using System;
using System.ServiceModel;

namespace ServerForDz2
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost service = new ServiceHost(typeof(Converter));
            Console.WriteLine("Started");
            service.Open();
            Console.ReadLine();
        }
    }
}
