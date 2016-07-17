using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple();
            Orange orange = new Orange();
            Watermelon watermelon = new Watermelon();
            apple.Punishment();
            orange.Punishment();
            watermelon.Punishment();
            Console.ReadKey();
        }
    }
}
