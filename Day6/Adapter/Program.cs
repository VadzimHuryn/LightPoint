using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Mechanic mech = new Mechanic();
            ITool toolPliers = new ToolAdapter();
            ITool toolWrenchOn12 = new WrenchOn12();
            mech.RemoveTheScrew(toolPliers);
            mech.RemoveTheScrew(toolWrenchOn12);
            Console.ReadKey();
        }
    }
}
