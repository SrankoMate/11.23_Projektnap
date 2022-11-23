using System;
using System.Collections.Generic;
using System.Text;

namespace MyFurniture
{
    abstract class Furniture
    {
        protected int ID;
        public Furniture(int ID)
        {
            this.ID = ID;
        }
        static int basePrice = 25000;
    }
}
