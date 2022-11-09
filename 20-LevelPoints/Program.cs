using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_LevelPoints
{
    internal class Program
    {
        /*
         * Passing the first level of a video game awards the player 1 point.
         * For each subsequent level passed, the points awarded increment by 1
         * (2 for the 2nd level, 3 for the third, and so on). 
         * 
         * The program you are given takes the number of passed levels as input. 
         * Complete the given function to take that number as an argument, and
         * recursively calculate and return the total number of points given for all
         * passed levels. 
         * 
         * Sample input: 3
         * Sample output: 6
         */

        static void Main(string[] args)
        {
            int levels = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Points(levels));

        }

        static int Points(int levels)
        {
            if(levels == 1)
            {
                return 1;
            }
            return levels + Points(levels - 1);
        }
    }
}
