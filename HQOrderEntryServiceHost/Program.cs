using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HQOrderEntryServiceHost
{
   public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Started");
            try
            {
                ServiceHost serviceHostOrderEntryService;
                serviceHostOrderEntryService = new ServiceHost(
                 typeof(HQOrderEntryImplementation.HQOrderEntryService));
                serviceHostOrderEntryService.Open();
                Console.WriteLine("OK");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                if (ex.InnerException != null)
                {
                    Console.WriteLine(ex.InnerException.Message);
                }
            }
            Console.ReadKey();
        }
    }
}
