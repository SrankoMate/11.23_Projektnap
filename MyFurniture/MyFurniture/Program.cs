using System;

namespace MyFurniture
{
    class Program
    {
        static void Main(string[] args)
        {
            Furniture[] bútorok = new Furniture[3];

            bútorok[0] = new Table(10);
            bútorok[1] = new Bed(100, 120);
            bútorok[2] = new Chair(4);

            for(int i = 0;i<bútorok.Length;i++)
            {
                bútorok[i].Print();
            }
        }
    }
}
