using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerAverageApp
{
    internal class ComputerAverageProgram
    {
        static void Main(string[] args)
        {
            // [] signifies array
            float[] user_grades = new float[5];
            float sum_of_grades = 0; // This code means that the float will initialize from 0

            //Input loop so that Users can enter multiple values before the console execute the next instruction
            Console.WriteLine($"Enter your grades:");
            for (int i = 0; i < 5; i++)
            {
                user_grades[i] = Convert.ToSingle(Console.ReadLine());
                sum_of_grades += user_grades[i];

            }

            float grade_average = sum_of_grades / 5;
            float rounded_grade_average = (int)Math.Round(grade_average); //Instead of (float), I turned it to (int) instead to round the numbers to in values

            Console.WriteLine($"The average of the grades is: {grade_average} \n The rounded average grade is: " + {rounded_grade_average});
           

            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();


        }
    }
}
