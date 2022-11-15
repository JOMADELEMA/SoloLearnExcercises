using System;

namespace HowMuchDoYouEarn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Write a program to take monthly salary as input, 
             * and calculate and output the annual income.
             * 
             * Sample: 800
             * Output: 9600
             */

            Console.Write("Enter the salary amount: ");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(salary*=12);
        }
    }
}
