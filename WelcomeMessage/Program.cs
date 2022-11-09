using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * You are organizing an important event and you should greet
             * each other participan with a welcome message. 
             * 
             * Complete the program to take the participant's name as input and
             * assign it to the "name" variable 
             * 
             * Sample input: Tom
             * Sample output: Hello Tom. Welcome to our event
             */
            Console.Write("Please enter the name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}. Welcome to our event");

        }
    }
}
