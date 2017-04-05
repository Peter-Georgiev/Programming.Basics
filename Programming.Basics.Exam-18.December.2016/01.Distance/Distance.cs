using System;
class Distance
{
    static void Main()
    {
        int speed = int.Parse(Console.ReadLine());
        int minutesOne = int.Parse(Console.ReadLine());
        int minutesTwo = int.Parse(Console.ReadLine());
        int minutesThree = int.Parse(Console.ReadLine());

        double kilometers = (double)speed * ((double)minutesOne / 60);
        double kilometersUp = ((double)speed * 1.1d) * ((double)minutesTwo / 60);
        double kilometersDown = (((double)speed * 1.1d) - ((((double)speed * 1.1d) * 5) / 100)) * ((double)minutesThree / 60);
        double mileageTotal = kilometers + kilometersUp + kilometersDown;

        Console.WriteLine($"{mileageTotal:F2}");
    }
}