using System;

namespace Óriásteknős
{
    class Program
    {
        static void Main(string[] args)
        {
            Food[] ételek = new Food[100];

            ételek[0] = new Crab(10);
            ételek[1] = new Crab(1);
            ételek[2] = new Salad();
            ételek[3] = new Crab(5);
            ételek[4] = new Crab(10);
            ételek[5] = new Crab(5);
            for (int i = 0; i < ételek.Length; i++)
                ételek[i].value();
            Turtle Tihi = new Turtle();
            Tihi.Eat();
        }
    }
}
