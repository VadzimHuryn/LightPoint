using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class WrenchOn12:ITool
    {
       public void Remove()
        {
            Console.WriteLine("Открутить");
        }
    }
}
