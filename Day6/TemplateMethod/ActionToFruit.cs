using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    abstract class ActionToFruit:ConflictWithFruit
    {
        public sealed override void Punishment()
        {
            Wash();
            Peel();
            Cut();
            Eat();
        }
        public abstract void Wash();
        public abstract void Peel();
        public abstract void Cut();
        public abstract void Eat();
    }
}
