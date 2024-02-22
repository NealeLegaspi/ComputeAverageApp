using System;

namespace ComputeAverageApp
{
    class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 grades separated by new line:");

            int[] grade = new int[5];

            for (int i = 0; i < 5; i++)
            {
                grade[i] = Convert.ToInt32(Console.ReadLine());
            }

            double average = (double)(grade[0] + grade[1] + grade[2] + grade[3] + grade[4]) / 5;

            int roundedOfaverage = (int)Math.Round(average);

            Console.WriteLine($"The average is {average:F1} and round off to {roundedOfaverage}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}