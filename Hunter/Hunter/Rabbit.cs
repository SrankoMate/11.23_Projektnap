using System;
using System.Collections.Generic;
using System.Text;

namespace Hunter
{
    class Rabbit : Animal
    {
        const double rabbitFactor = 0.3;
        public override double getPrice()
        {
            return base.getPrice() * rabbitFactor;
        }
    }
}
