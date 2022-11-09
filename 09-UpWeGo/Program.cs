using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_UpWeGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Anna's hummingbird, now believed to be the fastest
             * bird in the world relative to its size, can reach speeds 
             * of 80km per hour. 
             * 
             * Write a program to output how many kilometers it will 
             * trael each hour over 5 hours of flight. 
             * 
             * Output
             * 80
             * 160
             * 240
             * 320
             * 400
             * 
             * Hint: simpy multiply 80 by a counter for each iteration
             * Use the for loop to perfomr the multiplications iteratively. 
             * 
             */

            int kmph = 80;

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(kmph*i);
            }

        }
    }
}
