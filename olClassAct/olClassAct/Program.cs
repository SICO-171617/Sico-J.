using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olClassAct
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // No.1
            string[] classmatesFriends = { "Erick", "Juan", "Limerick", "Alex", "Rica", "Dale" };

            Console.WriteLine("No.1");
            Console.WriteLine("Names of my friends/classmates:");

            foreach (string names in classmatesFriends)
            {
                Console.WriteLine(names);
            }
            Console.WriteLine("\n");
            //====================================================================

            Console.WriteLine("No.2");
            // No.2

            char[,] sixAlphabets = new char[2, 3]
            {
                { 'A', 'B', 'C' },
                { 'D', 'E', 'F' }
            };

           
            Console.WriteLine("Two dimensional array:");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(sixAlphabets[i, j] + " ");
                }
                Console.WriteLine(""); 
            }

            Console.WriteLine("\n");
            //=========================================================================

            Console.WriteLine("No.3");
            // No.3
            string message = "hello world.";

            bool hellomessage = message.Contains("hello");

            if (hellomessage)
            {
                Console.WriteLine("'hello' word found.");
            }
            else
            {
                Console.WriteLine("no 'hello' word in the message.");
            }


            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();

        }
    }
}
