using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Act1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Puting value in a data type
            const double Price = 32.50;

            Console.WriteLine("Enter the number of apples you want to buy: ");
            int No_of_apples = Convert.ToInt32(Console.ReadLine());

            double total_price_of_apple = No_of_apples * Price;

            int totalPriceWholeNumber = (int)Math.Round(total_price_of_apple);//Converts double into integer

            Console.WriteLine($"The total price is: {total_price_of_apple:F2}");//String interpolation with 2 decimal points for the double value 

            Console.WriteLine($"The rounded total price is: {totalPriceWholeNumber}");

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();


        }
    }
}
