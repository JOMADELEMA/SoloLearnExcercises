using System;

namespace _16_SeeItAndForgetIt
{
    internal class Program
    {
        /*
         * You are making your own social network application. 
         * The users are able to set their names, teir ages, and
         * their preferred language. 
         * If user doesn't set the language, English will be set as
         * default. 
         * 
         * Complete the method with name, age and language parameters
         * and take itnto account the default Englis option for 
         * language in order to correctly output the information about 
         * the provided 2 users. 
         */
        static void Main(string[] args)
        {
            Settings("James", 25, "Spanish");
            Settings("Tom", 36);
        }

        static void Settings(string name, int age, string lang = "English")
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Language: " + lang);
        }
    }
}
