using System;
using System.Collections.Generic;
using System.Text;

namespace Óriásteknős
{
    class Salad : Food
    {
        protected int Saladtápérték = 10;
        public override int value()
        {
            return base.value()+Saladtápérték;
        }
    }
}
