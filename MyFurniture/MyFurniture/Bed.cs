using System;
using System.Collections.Generic;
using System.Text;

namespace MyFurniture
{
    class Bed : Furniture
    {
        protected int hossz;
        protected int szélesség;
        const double bedFactor = 2.4;
        public Bed(int hossz,int szélesség) :base()
        {
            this.hossz = hossz;
            this.szélesség = szélesség;
        }
        public override double Price()
        {
            return base.Price() * bedFactor;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Az ágy hossza:"+hossz);
            Console.WriteLine("Az ágy szélessége:"+szélesség);
            Console.WriteLine("");
        }
    }
}
