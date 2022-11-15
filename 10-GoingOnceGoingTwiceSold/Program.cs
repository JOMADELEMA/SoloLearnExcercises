using System;

namespace GoingOnceGoingTwiceSold
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * We are making a program for autcion with a maximum
             * bid set. The count of bids if variable. 
             * 
             * Write a program to take the maximum bid as input
             * then take all bids from auction participants until the maximum bid is exceeded. 
             * 
             * The program should output the corresponding message
             * with the winning bid. 
             * 
             * Sample input:
             * 1600
             * 800
             * 1300
             * 1700
             * 
             * Sample ouput:
             * Sold: 1700
             * 
             * Explanation
             * The first input represents the maximum bid, followed by the bids 
             * offered from all participans. The last participant suggested a bid 
             * (1700) which is above the maximum (1600) and won the auction. Thus, that 
             * bid is outputted. 
             * 
             * Hint:
             * In order to make continuous input acceptance you need to use while(true) condition.
             */
            int maxBid = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                int newBid = Convert.ToInt32(Console.ReadLine());
                if (newBid > maxBid)
                {
                    Console.WriteLine($"Sold: {newBid}");
                    break;
                }
            }
        }
    }
}
