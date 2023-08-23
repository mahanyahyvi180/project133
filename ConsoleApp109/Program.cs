using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp109
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int gradeCounter = 0;
            int aCount = 0;
            int bCount = 0;
            int cCount = 0;
            int dCount = 0;
            int fCount = 0;

            Console.WriteLine("Enter the integer grades in the range 0-100. ");
            Console.WriteLine("Type<Ctrl> z and press Enter to terminate input:");

            string input = Console.ReadLine();

            while (input != null)
            {
                int grade = int.Parse(input);
                total += grade;
                ++gradeCounter;

                switch (grade / 10)
                {

                    case 9:
                    case 10:
                        ++aCount;
                        break;

                    case 8:
                        ++bCount;
                        break;

                    case 7:
                        ++cCount;
                        break;

                    case 6:
                        ++dCount;
                        break;

                    default:
                        ++fCount;
                        break;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("\nGrade Report:");

            if (gradeCounter != 0)
            {
                double avergae = (double)total / gradeCounter;

                Console.WriteLine($"Total of the{gradeCounter}grades entered is{total}");
                Console.WriteLine($"Class average is{avergae:F}");
                Console.WriteLine("Number of students who received each grade:");

                Console.WriteLine($"A: {aCount}");
                Console.WriteLine($"B: {bCount}");
                Console.WriteLine($"C: {cCount}");
                Console.WriteLine($"D: {dCount}");
                Console.WriteLine($"F: {fCount}");
            }
            else
            {
                Console.WriteLine("No grades were entered ");
                Console.ReadLine();
            }
        }
    }
}
