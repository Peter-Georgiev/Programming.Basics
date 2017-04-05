using System;
class ProspectInHospitality
{
    static void Main()
    {
        uint builders = uint.Parse(Console.ReadLine());
        uint receptionists = uint.Parse(Console.ReadLine());
        uint chambermaids = uint.Parse(Console.ReadLine());
        uint technicians = uint.Parse(Console.ReadLine());
        uint other = uint.Parse(Console.ReadLine());
        decimal salaryNiki = decimal.Parse(Console.ReadLine());
        decimal currencyUSA = decimal.Parse(Console.ReadLine());
        decimal yourSalary = decimal.Parse(Console.ReadLine());
        decimal budget = decimal.Parse(Console.ReadLine());

        decimal result = (builders * 1500.04m) + (receptionists * 2102.10m) +
            (chambermaids * 1465.46m) + (technicians * 2053.33m) +
            (other * 3010.98m) + (salaryNiki * currencyUSA) + yourSalary;
        decimal left = budget - result;

        Console.WriteLine($"The amount is: {result:F2} lv.");

        if (left >= 0)
        {
            Console.WriteLine($"YES \\ Left: {left:F2} lv.");
        }
        else
        {
            left = result - budget;
            Console.WriteLine($"NO \\ Need more: {left:F2} lv.");
        }
    }
}