using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmStudentGradeProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Name: ");
            String student_name = Console.ReadLine();

            Console.WriteLine("Grades");

            Console.WriteLine("English: ");
            float grade_eng = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Math: ");
            float grade_math = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Science: ");
            float grade_science = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Filipino: ");
            float grade_filipino = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("History: ");
            float grade_history = Convert.ToSingle(Console.ReadLine());

            float total_grade = grade_eng + grade_filipino + grade_history + grade_math + grade_science;
            float total_grade_average = total_grade / 5;
            float total_grade_average1 = (float)Math.Round(total_grade_average, 2);

            if (total_grade_average1 > 75.00)
            {
                Console.WriteLine("The Student Passed!\nThe general average of " + student_name + " is " + total_grade_average1);
            }
            else
            {
                Console.WriteLine("The Student Failed!\nThe general average of " + student_name + " is " + total_grade_average1);

            }

            Console.WriteLine("Press anything to continue");
            Console.ReadKey();
        }
    }
}