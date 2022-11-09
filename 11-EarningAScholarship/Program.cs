using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_EarningAScholarship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Students should have at least 95% attendance and an 
             * average score of 80 to win a scholarship. 
             * 
             * Write a program to take attendance and average score
             * alues as input and output "Accepted", if the given requirements
             * are satisfied, and "Denied", if they are not. 
             * 
             * Sample input:
             * 98
             * 70
             * 
             * Expected Output 
             * Denied
             */

            Console.Write("Enter the Attendance value: ");
            int attendance = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Average Score: ");
            int avgScore = Convert.ToInt32((Console.ReadLine()));   

            if(attendance >=95 && avgScore >= 80)
            {
                Console.WriteLine("Accepted");
            }
            else
            {
                Console.WriteLine("Denied");
            }

        }
    }
}
