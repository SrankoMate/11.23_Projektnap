using System;
using System.Collections.Generic;
using System.Text;

namespace MyFurniture
{
    class Bed : Furniture
    {
        protected int hossz;
        protected int szélesség;
        public Bed(int hossz,int szélesség, int ID) :base(ID)
        {
            this.hossz = hossz;
            this.szélesség = szélesség;
        }
        const double bedFactor = 2.4;
    }
}
