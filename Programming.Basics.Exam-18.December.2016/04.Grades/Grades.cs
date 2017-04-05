using System;
class Grades
{
    static void Main()
    {
        int inStudents = int.Parse(Console.ReadLine());
        double[] examAssessment = new double[inStudents];
        for (int i = 0; i < examAssessment.Length; i++)
        {
            examAssessment[i] = double.Parse(Console.ReadLine());
        }

        double topStudents = 0, oneBetween = 0, twoBetween = 0, fail = 0, average = 0;

        for (int i = 0; i < examAssessment.Length; i++)
        {
            if (examAssessment[i] >= 2.00 && examAssessment[i] <= 2.99)
            {
                fail++;
            }

            if (examAssessment[i] >= 3.00 && examAssessment[i] <= 3.99)
            {
                twoBetween++;
            }

            if (examAssessment[i] >= 4.00 && examAssessment[i] <= 4.99)
            {
                oneBetween++;
            }

            if (examAssessment[i] >= 5.00)
            {
                topStudents++;
            }
        }

        for (int i = 0; i < examAssessment.Length; i++)
        {
            average += examAssessment[i];
        }
        average /= (double)inStudents;

        topStudents = (topStudents / (double)inStudents) * 100;
        oneBetween = (oneBetween / (double)inStudents) * 100;
        twoBetween = (twoBetween / (double)inStudents) * 100;
        fail = (fail / (double)inStudents) * 100;

        Console.WriteLine($"Top students: {topStudents:F2}%");
        Console.WriteLine($"Between 4.00 and 4.99: {oneBetween:F2}%");
        Console.WriteLine($"Between 3.00 and 3.99: {twoBetween:F2}%");
        Console.WriteLine($"Fail: {fail:F2}%");
        Console.WriteLine($"Average: {average:F2}");
    }
}