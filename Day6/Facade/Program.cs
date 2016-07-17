using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple();
            Orange orange = new Orange();
            Watermelon watermelon = new Watermelon();
            Person person = new Person();
            FruitFacade fruit = new FruitFacade(apple, orange, watermelon);
            person.EatFruit(fruit);
            Console.ReadKey();

        }
    }
}
