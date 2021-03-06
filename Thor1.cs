using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Thor1
{
    class Player
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int lightX = int.Parse(inputs[0]); // the X position of the light of power
            int lightY = int.Parse(inputs[1]); // the Y position of the light of power
            int initialTx = int.Parse(inputs[2]); // Thor's starting X position
            int initialTy = int.Parse(inputs[3]); // Thor's starting Y position
            int thor_x = initialTx;
            int thor_y = initialTy;
            Console.Error.WriteLine("Debug messages...");
            Console.Error.WriteLine(thor_x);
            // game loop
            while (true)
            {
                int remainingTurns = int.Parse(Console.ReadLine()); // The remaining amount of turns Thor can move. Do not remove this line.
                string dirX = "";
                string dirY = "";
                if (thor_y > lightY)
                {
                    dirY = "N";
                    thor_y -= 1;
                }

                else if (thor_y < lightY)
                {
                    dirY = "S";
                    thor_y += 1;
                }
                Console.Error.WriteLine(dirY);
                if (thor_x > lightX)
                {
                    dirX = "W";
                    thor_x -= 1;
                }
                else if (thor_x < lightX)
                {
                    dirX = "E";
                    thor_x += 1;
                }


                // A single line providing the move to be made: N NE E SE S SW W or NW
                Console.WriteLine(dirY + dirX);
            }
        }
    }
}
