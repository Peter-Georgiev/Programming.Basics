using System;

class WorkHours
{
    static void Main()
    {
        int requiredHours = int.Parse(Console.ReadLine());
        int numberBuilder = int.Parse(Console.ReadLine());
        int workingDays = int.Parse(Console.ReadLine());

        int hours = numberBuilder * (workingDays * 8);
        
        if (hours >= requiredHours)
        {
            int remainHours = hours - requiredHours;
            Console.WriteLine($"{remainHours} hours left");
        }
        else
        {
            int overtime = requiredHours - hours;
            int penalties = overtime * workingDays;
            Console.WriteLine($"{overtime} overtime");
            Console.WriteLine($"Penalties: {penalties}");
        }
    }
}