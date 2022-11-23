using System;

namespace Hunter
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] állatok = new Animal[3];

            állatok[0] = new Rabbit();
            állatok[1] = new PolarBear();
            állatok[2] = new Squirrel();
            
            for(int i = 0;i<állatok.Length;i++)
            {
                Console.Write(állatok[i].getPrice()+"FT az értéke a prémjének"+" a(z) ");
                Console.Write(állatok[i].GetType()+ "-nak/nek");
                Console.WriteLine("");
            }
        }
    }
}
