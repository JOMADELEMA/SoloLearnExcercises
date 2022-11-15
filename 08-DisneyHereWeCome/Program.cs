using System;

namespace _08_DisneyHereWeCome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * You work on a particular carousel at Disney. You have
             * to count from 3 to 0 on the scrren before running the carousel. 
             * 
             * Write a program to output all the nunmbers from 3 to 0
             * in this format:
             * 
             * 3
             * 2
             * 1
             * 0
             * 
             * Notice that each number should be outputted on a new line. 
             */

            int number = 3;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
        }
    }
}
