using System;
using System.Collections.Generic;
using System.Text;

namespace Hunter
{
    abstract class Animal
    {
        const int basePrice = 100000;
        public virtual double getPrice()
        {
            return basePrice;
        }
    }
}
