﻿using System;

namespace Óriásteknős
{
    class Program
    {
        static void Main(string[] args)
        {
            Food[] ételek = new Food[6];

            ételek[0] = new Crab(10);
            ételek[1] = new Crab(1);
            ételek[2] = new Salad();
            ételek[3] = new Crab(5);
            ételek[4] = new Crab(10);
            ételek[5] = new Crab(5);
            Turtle Tihi = new Turtle();

            for (int i = 0; i < ételek.Length; i++)
            Tihi.Eat(ételek[i].value());
        }
    }
}
