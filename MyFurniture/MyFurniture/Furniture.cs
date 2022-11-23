using System;
using System.Collections.Generic;
using System.Text;

namespace MyFurniture
{
    abstract class Furniture
    {
        protected int ID;
        static int basePrice = 25000;
        public Furniture()
        {
            this.ID = getID(); // hiba
        }
        public int getID()
        {
            return ID++;
        }
        public virtual double Price()
        {
            return basePrice;
        }
        public virtual void Print()
        {
            Console.WriteLine("A bútor egyedi azonosítója:"+ID);
            Console.WriteLine("A bútor összege:" + Price());
        }
    }
}
