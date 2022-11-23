using System;
using System.Collections.Generic;
using System.Text;

namespace MyFurniture
{
    class Table : Furniture
    {
        protected int magasság;
        const double TableFactor = 0.3;
        public Table(int magasság) :base()
        {
            this.magasság = magasság;
        }
        public override double Price()
        {
            return base.Price() * TableFactor;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Az asztal magassága:"+magasság);
            Console.WriteLine("");
        }
    }
}
