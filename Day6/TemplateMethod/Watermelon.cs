using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Watermelon:ActionToFruit
    {
        public override void Wash()
        {
            Console.WriteLine("Вымыть арбуз");
        }
        public override void Peel()
        {
            Console.WriteLine("Очистить арбуз от кожуры (надо так!)");
        }
        public override void Cut()
        {
            Console.WriteLine("Разрезать арбуз");
        }
        public override void Eat()
        {
            Console.WriteLine("Съесть арбуз");
        }
    }
}
