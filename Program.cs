using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            double sumOfGrades = 0;
            int excludedCounter = 0;
            int grade = 1;

            while (grade <= 12)
            {
                double currentGrade = double.Parse(Console.ReadLine());

                if (currentGrade < 4)
                {
                    excludedCounter++;
                }
                if (excludedCounter == 2)
                {
                    Console.WriteLine($"{name} has been excluded at {grade - 1} grade");
                    break;
                }
                sumOfGrades += currentGrade;
                grade++;
            }
            double avg = sumOfGrades / 12;
            if (excludedCounter < 2)
            {
                Console.WriteLine($"{name} graduated. Average grade: {avg:f2}");
            }
        }
    }
}
