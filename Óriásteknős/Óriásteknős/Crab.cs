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
            this.méret = méret;
        }
        public override int value()
        {
            return base.value()+(méret * Crabtápérték);
        }
    }
}
