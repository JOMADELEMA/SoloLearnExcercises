using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetThatDiscount
{
    internal class Program
    {
            /*
             * A store is running a promotion: if the total purchase
             * price is equal to or exceeds 10000, the price will be discounted 
             * by 20%.
             * The program you are given takes the total purchase price as input. 
             * 
             * Complete the given method to take the total purchase 
             * price as an argument, and calculate and return the discounted price
             * if campaign's requirement is satisfied. 
             * The method should return the same price if discount is not given. 
             * 
             * Sample input: 13000
             * 
             * Sample output: 10400
             */
        static void Main(string[] args)
        {
            int totalPrice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Discount(totalPrice));
        }

        static int Discount(int purchaseAmount)
        {
            if(purchaseAmount >= 10000)
            {
                return purchaseAmount -(Convert.ToInt32(purchaseAmount* 0.2));
            }
            else
            {
                return purchaseAmount;
            }
        }
    }
}
