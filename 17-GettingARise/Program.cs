using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_GettingARise
{
    internal class Program
    {
        /*
         * Management has decided to increase the total salary budget. 
         * 
         * The program you are given takes the current salary budget
         * and the raise percentage as input. It should output 
         * the salary budget before the increase, then calculate 
         * and output the budget with the raises included. 
         * 
         * Fix the program by completing the Increase() method (which 
         * should calculate the new salary budget) and callint it, so
         * that the provided outputs work correctly. 
         * 
         * Sample input 
         * 150000
         * 15
         * 
         * Sample output
         * Before the increase: 150000
         * After the increase: 172500
         * 
         * 
         * 
         */
        static void Main(string[] args)
        {
            int salaryBudget = Convert.ToInt32(Console.ReadLine());
            int percent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before the increase: " + salaryBudget);

            Increase(ref salaryBudget, percent);

            Console.WriteLine("After the increase: " + salaryBudget);
        }

        static void Increase(ref int salaryBudget, int percent)
        {
            //salaryBudget = Convert.ToInt32(salaryBudget*Convert.ToDouble((1+percent/100)));
            salaryBudget= Convert.ToInt32(salaryBudget*(1+Convert.ToDouble(percent)/100));
        }
    }
}
