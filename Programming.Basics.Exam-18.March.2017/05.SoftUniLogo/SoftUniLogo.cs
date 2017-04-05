using System;

class SoftUniLogo
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int center = 1;
        int point = (12 * number - 5) - center;

        for (int i = 0; i < number * 2; i++)
        {
            Console.Write(new string('.', point / 2));
            Console.Write(new string('#', center));
            Console.WriteLine(new string('.', point / 2));
            center += 6;
            point = (12 * number - 5) - center;
        }

        point = 6;
        center = (12 * number - 5) - point;

        for (int i = 0; i < (4 * number - 2) - (number * 2) - number; i++)
        {
            Console.Write($"|{new string('.', point / 2 - 1)}");
            Console.Write(new string('#', center));
            Console.WriteLine(new string('.', point / 2));
            point += 6;
            center = (12 * number - 5) - point;
        }

        for (int i = 1; i <= number; i++)
        {
            if (i == number)
            {
                Console.Write($"@{new string('.', point / 2 - 1)}");
            }
            else
            {
                Console.Write($"|{new string('.', point / 2 - 1)}");
            }
            
            Console.Write(new string('#', center));
            Console.WriteLine(new string('.', point / 2));            
        }
    }
}