using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Client
    {
        AbstractBox abstractBox;
        AbstractPhone abstractPhone;
        public Client(AbstractFactory abstractFactory)
        {
            abstractBox = abstractFactory.CreateBox();
            abstractPhone = abstractFactory.CreatePhone();
        }

        public void Run()
        {
            abstractBox.Integrate(abstractPhone);
        }
    }
}
