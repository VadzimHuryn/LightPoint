using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory abstractFactory = null;
            AbstractBox abstractBox = null;
            AbstractPhone abstracPhone = null;

            abstractFactory = new IphoneFactory();
            abstractBox = abstractFactory.FactoryMethod2();
            abstracPhone = abstractFactory.FactoryMethod1();
        }
    }
}
