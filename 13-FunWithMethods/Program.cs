using System;

namespace _13_FunWithMethods
{
    internal class Program
    {
        /*
         * Call the method and print "This is my first method"
         */
        static void Main(string[] args)
        {
            myFunc();
        }

        static void myFunc() => Console.WriteLine("This is my first method");
    }
}
