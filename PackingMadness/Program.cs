using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingMadness
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * We need to pack 142 toys in boxes. each box holds 
             * 15 toys. 
             * 
             * Write a program to calculate and output how many toys
             * will be left after packing 
             * 
             * 
             */

            float toys = 142f;
            float boxCapacity = 15f;

            Console.WriteLine(toys % boxCapacity);


        }
    }
}
