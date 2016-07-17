using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Apple:ActionToFruit
    {
        public override void Wash()
        {
            Console.WriteLine("Вымыть яблоко");
        }
        public override void Peel()
        {
            Console.WriteLine("Очистить яблоко от кожуры");
        }
        public override void Cut()
        {
            Console.WriteLine("Разрезать яблоко");
        }
        public override void Eat()
        {
            Console.WriteLine("Съесть яблоко");
        }
    }
}
