using System;
using System.ServiceModel;


namespace WCF2
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(DiscInfo));
            host.Open();
            Console.WriteLine("Service start");
            Console.ReadLine();
        }
    }
}
