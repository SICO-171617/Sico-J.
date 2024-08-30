using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Setting up File Directory
            string pathDirectory = @"D:\Game"; //checks the path directory of the files

            string[] filesToCheck =
            {
                "GoodMoral.pdf",
                "Form137.pdf",
                "grades.pdf"
            };

            string[] requirements = { "More than 32,000 pesos", "Good Moral", "SHS Diploma", "Form 137", "PSA", "Medical Certificate" };

            while (true)
            {
                Console.Clear(); // Clear the console for each iteration
                Console.WriteLine("Greetings! To enroll here in STI you must have the following!");

                Console.WriteLine("===========================================================");

                foreach (string str in requirements)// lists the requirements
                {
                    Console.WriteLine("- " + str);
                }

                Console.WriteLine("\n");

                Console.WriteLine("===========================================================");
                Console.WriteLine("=======================FUND CHECKER========================");
                Console.WriteLine("===========================================================");

                Console.WriteLine("How much money do you have? ");
                int tuition_money = Convert.ToInt32(Console.ReadLine());

                if(tuition_money < 32000)//if-else condition that determines if the user has sufficient funds to register
                {
                    Console.WriteLine("Insufficient Funds!");
                }
                else
                {
                    Console.WriteLine("===========================================================");
                    Console.WriteLine("Sufficient Funds");
                }

                Console.WriteLine("\n");
                Console.WriteLine("===========================================================");
                Console.WriteLine("=======================FILE CHECKER========================");
                Console.WriteLine("===========================================================");

                Boolean fileExist = true;

                foreach (string fileName in filesToCheck)//Checks files or file names if certain files exists
                {
                    string filePath = Path.Combine(pathDirectory, fileName);
                    if (File.Exists(filePath)) //nested if-else condition that checks if the files exists and tells the user if they do have the files
                    {
                        Console.WriteLine($"File {fileName} exists");
                    }
                    else
                    {
                        Console.WriteLine($"File {fileName} does not exist");
                        fileExist = false;
                    }
                }
                Console.WriteLine("===========================================================");

                if (!fileExist) //if-else condition that tells the user if they met all the requirements
                {
                    Console.WriteLine("Requirements not Met!");
                }
                else
                {
                Console.WriteLine("All requirements met!");
                }

                Console.WriteLine("\nPress 'K' to quit or any other key to check again.");
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.K)
                {
                    break; 
                }
            }
        }
    }
}
