using System;

namespace _18_Overloading
{
    internal class Program
    {
        /*
         * Complete the Add() mehod so that it will calculate the sum of two numbers
         * given as arugments. 
         * Overload it in order to do the same operation with double type values. 
         */

        static void Main(string[] args)
        {
            Console.WriteLine(Add(10, 12));
            Console.WriteLine(Add(1.5, 2.9));
        }

        static int Add(int num1, int num2) => num1 + num2;

        static double Add(double num1, double num2) => num1 + num2;
    }
}
