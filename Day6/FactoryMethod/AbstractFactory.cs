using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class AbstractFactory
    {
        AbstractPhone phone;
        AbstractBox box;
        public abstract AbstractPhone FactoryMethod1();
        public abstract AbstractBox FactoryMethod2();

        public void AnOperation()
        {
            phone = FactoryMethod1();
            box = FactoryMethod2();
        }
    }
}
