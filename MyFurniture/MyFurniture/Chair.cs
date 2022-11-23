using System;
using System.Collections.Generic;
using System.Text;

namespace MyFurniture
{
    class Chair : Furniture
    {
        protected int lábszáma;
        const double chairFactor = 1.2;
        public Chair(int lábszáma) : base()
        {
            this.lábszáma = lábszáma;
        }
        public override double Price()
        {
            return base.Price() * chairFactor;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("A szék lábszáma:"+lábszáma);
        }
    }
}
