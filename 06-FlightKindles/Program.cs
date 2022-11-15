using System;

namespace FlightKindles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Airlines are offering a special promotion for teenagers
             * and are offeritn kindles to us during the flight. 
             * Write a program to take passenger's age as input, and output 
             * "Take your kindle", if the age is under or equal to 19.
             * 
             * Sample input 14
             */

            int age = Convert.ToInt32(Console.ReadLine());

            if (age <= 19)
                Console.WriteLine("Take your kindle");
        }
    }
}
