using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifficultyLevels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * You are making a game, where the placer selects the difficulty level. 
             * 
             * 1 - Easy
             * 2 - Medium
             * 3 - Hard
             * 
             * You are given a program that takes the number as input. 
             * 
             * Complete the program so that it will output the corresponding 
             * difficulty level. 
             * If the user entered an indvalid number, the program should output 
             * "Invalid output" 
             * 
             * Sample input: 2
             * Sample ouput: Medium
             */

            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Easy");
                    break;
                case 2:
                    Console.WriteLine("Medium");
                    break;
                case 3:
                    Console.WriteLine("Hard");
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}
