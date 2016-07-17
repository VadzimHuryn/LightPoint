using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SamsungFactory:AbstractFactory
    {
        public override AbstractBox CreateBox()
        {
            return new SamsungBox();
        }
        public override AbstractPhone CreatePhone()
        {
            return new Samsung();
        }
    }
}
