using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesApp
{
    internal class DataTypesProgram
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the pieces of apple: ");
            int apple_count = Convert.ToInt32(Console.ReadLine()); //Convert.ToInt32() performs conversions and returns int representation of input  

            Console.WriteLine("Enter total price of " + apple_count + " apple : ");
            float apple_price = Convert.ToSingle(Console.ReadLine()); //Convert.ToSingle32() performs conversions and returns  float  representation of input

            Console.WriteLine("The total price of " + apple_count + " is " + apple_price); //Concatenations

            Console.WriteLine("The value of the converted price is " + (int)apple_price); //Data type conversion

            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }
    }
}
