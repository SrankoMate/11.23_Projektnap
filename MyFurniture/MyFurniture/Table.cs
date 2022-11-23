using System;
using System.Collections.Generic;
using System.Text;

namespace MyFurniture
{
    class Table : Furniture
    {
        protected int magasság;
        public Table(int magasság,int ID) :base(ID)
        {
            this.magasság = magasság;
        }
        const double TableFactor = 0.3;
    }
}
