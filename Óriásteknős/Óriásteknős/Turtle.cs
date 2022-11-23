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
            if(fedLevel > 1000)
                Console.WriteLine("Tihi jóllakottsági szintje tele van.");
            else
            {
                fedLevel += a;
                Console.WriteLine("A hozzáadott value:"+a);
                Console.WriteLine(fedLevel);
            }

            if (fedLevel < 500)
            {
                Console.WriteLine("A bevitt tápérték 500 alatt van.");
                happiness++;
            }
            else
            {
                Console.WriteLine("A bevitt tápérték 500 felett van.");
                happiness--;
            }
        }
    }
}
