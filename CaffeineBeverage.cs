using System;
using System.Collections.Generic;
using System.Text;

namespace Starbu__
{
    public abstract class CaffeineBeverage
    {
        public abstract void prepareRecipe();
        
        public void boilWater()
        {
            Console.WriteLine("Boiling water");
        }
        public void pourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

    }
}
