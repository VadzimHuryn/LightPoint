using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class FruitFacade
    {
        Apple apple;
        Orange orange;
        Watermelon watermelon;
        public FruitFacade(Apple apple, Orange orange, Watermelon watermelon )
        {
            this.apple = apple;
            this.orange = orange;
            this.watermelon = watermelon;
        }
        public void EatFruit()
        {
            apple.Eat();
            orange.Peel();
            orange.Eat();
            watermelon.Cut();
            watermelon.Eat();
        }
    }
}
