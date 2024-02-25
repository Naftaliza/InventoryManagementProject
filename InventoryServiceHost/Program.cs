using System;
using System.ServiceModel;
using WCFProject;

namespace InventoryServiceHost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(InventoryService)))
            {
                host.Open();
                Console.WriteLine("Service is running...");
                Console.ReadLine();
            }

        }
    }
}
