using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_RecursiveSumming
{
    internal class Program
    {
        /*
         * Write a program to take N numbers as input and recursively
         * calculate the sum of all numbers from 1 to N. 
         * 
         * Sample input: 5
         * Sample output: 15
         * 
         * Don't forget about the base case
         */
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Sum(number));
        }

        static int Sum(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            return num + Sum(num - 1);
        }
    }
}
