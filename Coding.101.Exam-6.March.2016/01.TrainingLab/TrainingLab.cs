using System;
class TrainingLab
{
    static void Main()
    {
        double w = double.Parse(Console.ReadLine()) * 100;
        double h = double.Parse(Console.ReadLine()) * 100;

        w = Math.Truncate(w / 120);
        h = Math.Truncate((h - 100) / 70);
        double result = w * h - 3;
        Console.WriteLine(result);
    }
}