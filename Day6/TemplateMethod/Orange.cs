using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Orange:ActionToFruit
    {
        public override void Wash()
        {
            Console.WriteLine("Вымыть апельсин");
        }
        public override void Peel()
        {
            Console.WriteLine("Очистить апельсин от кожуры");
        }
        public override void Cut()
        {
            Console.WriteLine("Разрезать апельсин");
        }
        public override void Eat()
        {
            Console.WriteLine("Съесть апельсин");
        }
    }
}
