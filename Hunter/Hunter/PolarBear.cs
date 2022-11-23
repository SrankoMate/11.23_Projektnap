using System;
using System.Collections.Generic;
using System.Text;

namespace Hunter
{
    class PolarBear : Animal
    {
        const double polarBearFactor = 2.4;
        public override double getPrice()
        {
            return base.getPrice() * polarBearFactor;
        }
    }
}
