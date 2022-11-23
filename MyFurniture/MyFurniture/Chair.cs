using System;
using System.Collections.Generic;
using System.Text;

namespace MyFurniture
{
    class Chair : Furniture
    {
        protected int lábszáma;
        public Chair(int lábszáma, int ID) : base(ID)
        {
            this.lábszáma = lábszáma;
        }
        const double chairFactor = 1.2;
    }
}
