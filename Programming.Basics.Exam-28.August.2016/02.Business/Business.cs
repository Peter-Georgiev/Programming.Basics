using System;
class Business
{
    static void Main()
    {
        int hoursIn = int.Parse(Console.ReadLine());
        int daysIn = int.Parse(Console.ReadLine());
        int employeeOvertime = int.Parse(Console.ReadLine());

        double training = (daysIn - (daysIn * 0.1)) * 8;
        int overtime = (employeeOvertime * 2) * daysIn;
        double timeOll = Math.Floor(training + overtime);
        int projectComletetd = (int)Math.Abs(timeOll - hoursIn);
        if (timeOll >= hoursIn)
        {
            Console.WriteLine($"Yes!{projectComletetd} hours left.");
        }
        else
        {
            Console.WriteLine($"Not enough time!{projectComletetd} hours needed.");
        }
    }
}