using System;
using System.Collections.Generic;
using System.Text;

namespace Hunter
{
    class Squirrel : Animal
    {
        const double squirrelFactor = 1.2;
        public override double getPrice()
        {
            return base.getPrice() * squirrelFactor;
        }
    }
}
