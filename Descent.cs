using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace The_Descent
{
    class Descent
    {
        static void Main(string[] args)
        {

            // game loop
            while (true)
            {
                int max = 0; //Initial Maximum Height of Mountain
                int h = 0; //Intial Mountain Index
                for (int i = 0; i < 8; i++)
                {
                    int mountainH = int.Parse(Console.ReadLine());// represents the height of one mountain.

                    if (mountainH > max)
                    {

                        max = mountainH; //Mountain with max height will be stored  
                        h = i; // Mountain index will be stored

                    }

                }
                Console.WriteLine(h); // Print the index of the Mountain with max Height

            }
        }
    }
}
