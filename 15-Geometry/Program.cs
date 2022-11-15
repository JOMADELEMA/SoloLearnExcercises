using System;

namespace _15_Geometry
{
    internal class Program
    {
        /*
         * You are writing a program to calculate the area of a reactangle.
         * Currently it takes the length and the height as inputs. 
         * 
         * Complete the given method to take them as arguents, then 
         * calculate and return the area
         * 
         * Sample input
         * 4
         * 5
         * 
         * Sample output
         * 20
         * 
         * To get the area multiply length * height
         * 
         */
        static void Main(string[] args)
        {
            int length = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Area(length, height));
        }

        static int Area(int length, int height) => length * height;
    }
}
