using System;
using System.Collections.Generic;
using System.Text;

namespace Óriásteknős
{
    class Crab :Food
    {
        protected int méret = 0;
        protected int Crabtápérték = 10;
        public Crab(int méret)
        {
            if(méret<=10&&méret>=1)
                this.méret = méret;
            else
                Console.WriteLine("Rossz a mérete a ráknak (1-10 közötti értéket adj meg)");
        }
        public override int value()
        {
            return base.value()+(méret * Crabtápérték);
        }
    }
}
