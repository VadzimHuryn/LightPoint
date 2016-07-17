using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class AbstractFactory
    {
        public abstract AbstractPhone CreatePhone();
        public abstract AbstractBox CreateBox();
    }
}
