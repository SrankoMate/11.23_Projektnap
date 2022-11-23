using System;
using System.Collections.Generic;
using System.Text;

namespace Óriásteknős
{
    class Turtle : Food
    {
        protected int happiness;
        protected int fedLevel;

        public void Eat(int a)
        {
            if(a<=100)
            {
                if (fedLevel > 1000)
                    Console.WriteLine("Tihi tele van, nem tudod etetni.");
                else
                    fedLevel += a;

                if (fedLevel < 500)
                {
                    Console.WriteLine("A bevitt tápérték 500 alatt van, növekszik Tihi boldogsága");
                    happiness++;
                }
                else
                {
                    Console.WriteLine("A bevitt tápérték 500 felett van, csökken Tihi boldogsága");
                    happiness--;
                }
                Console.WriteLine("Tihi jelenlegi boldogsága szintje:" + happiness);
                Console.WriteLine("");
            }
        }
    }
}
