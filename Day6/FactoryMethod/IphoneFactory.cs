using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class IphoneFactory:AbstractFactory
    {
        public override AbstractBox FactoryMethod2()
        {
            return new IphoneBox();
        }
        public override AbstractPhone FactoryMethod1()
        {
            return new Iphone();
        }
    }
}
