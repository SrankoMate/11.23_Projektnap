using System;
using System.Collections.Generic;
using System.Text;

namespace Óriásteknős
{
    class Turtle : Food
    {
        protected int happiness;
        protected int fedLevel;

        public void Eat()
        {
            if(fedLevel > 1000)
                Console.WriteLine("Tihi jóllakottsági szintje tele van.");
            else
            {
                fedLevel += value();
                Console.WriteLine("A hozzáadott value:"+value());
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
