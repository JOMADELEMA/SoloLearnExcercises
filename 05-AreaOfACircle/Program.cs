using System;

namespace _05_AreaOfACircle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * We are going to write a program that will calculate the area of a circle. 
             * The area enclosed by a circle of radius r is pi * r*r, where pi
             * is the constant ratio of the circumference of any circle to its diameter, 
             * and r is the radius. 
             * 
             * The given program declares a constant pi variable with a value of 3.14
             * Complete the program to take the radius as input, then calculate
             * and output the area of the circle. 
             */

            const double pi = 3.14;
            double radius;

            Console.Write("Enter the radius of the circle: ");
            radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(pi * (radius * radius));
        }
    }
}
