using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var queryProcessor = new QueryProcessor(new DatabaseConnectionProvider(), new ConfigurationProvider());

            var product = queryProcessor.GetResultQuery1();
            var person = queryProcessor.GetResultQuery2();
            var card = queryProcessor.GetResultQuery3();


            Console.ReadKey();
        }
    }
}
