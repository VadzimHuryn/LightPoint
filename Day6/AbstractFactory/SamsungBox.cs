using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SamsungBox:AbstractBox
    {
        public override void Integrate(AbstractPhone phone)
        {
            Console.WriteLine(phone +" to put in the " + this);
        }
    }
}
