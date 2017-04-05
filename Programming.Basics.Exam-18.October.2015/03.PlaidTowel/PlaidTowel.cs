using System;

class PlaidTowel
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        char symbolOne = char.Parse(Console.ReadLine());
        char symbolTwo = char.Parse(Console.ReadLine()); ;

        //up
        int leftOrRight = 1;
        int center = number * 4 + 1;

        Console.Write($"{new string(symbolOne, number)}{symbolTwo}");
        Console.Write($"{new string(symbolOne, center - (number * 2) - 2)}");
        Console.WriteLine($"{symbolTwo}{new string(symbolOne, number)}");

        for (int i = number - 1; i > 0; i--)
        {
            center = (number * 4 + 1) - (i * 2) - (leftOrRight * 2) - 4;

            Console.Write($"{new string(symbolOne, i)}{symbolTwo}");
            Console.Write($"{new string(symbolOne, leftOrRight)}{symbolTwo}");
            Console.Write($"{new string(symbolOne, center)}{symbolTwo}");
            Console.Write($"{new string(symbolOne, leftOrRight)}{symbolTwo}");
            Console.WriteLine($"{new string(symbolOne, i)}");
                        
            leftOrRight += 2;
        }

        Console.Write($"{symbolTwo}{new string(symbolOne, leftOrRight)}");
        Console.WriteLine($"{symbolTwo}{new string(symbolOne, leftOrRight)}{symbolTwo}");
        center = 1;

        for (int i = 1; i < number; i++)
        {
            leftOrRight = ((number * 4 + 1) - (i * 2) - center - 4) / 2;

            Console.Write($"{new string(symbolOne, i)}{symbolTwo}");
            Console.Write($"{new string(symbolOne, leftOrRight)}{symbolTwo}");
            Console.Write($"{new string(symbolOne, center)}{symbolTwo}");
            Console.Write($"{new string(symbolOne, leftOrRight)}{symbolTwo}");
            Console.WriteLine($"{new string(symbolOne, i)}");
            center += 2;
            leftOrRight -= 2;
        }

        center = number * 4 + 1;

        Console.Write($"{new string(symbolOne, number)}{symbolTwo}");
        Console.Write($"{new string(symbolOne, center - (number * 2) - 2)}");
        Console.WriteLine($"{symbolTwo}{new string(symbolOne, number)}");

        //down

        leftOrRight = 1;
        center = number * 4 + 1;

        for (int i = number - 1; i > 0; i--)
        {
            center = (number * 4 + 1) - (i * 2) - (leftOrRight * 2) - 4;

            Console.Write($"{new string(symbolOne, i)}{symbolTwo}");
            Console.Write($"{new string(symbolOne, leftOrRight)}{symbolTwo}");
            Console.Write($"{new string(symbolOne, center)}{symbolTwo}");
            Console.Write($"{new string(symbolOne, leftOrRight)}{symbolTwo}");
            Console.WriteLine($"{new string(symbolOne, i)}");

            leftOrRight += 2;
        }

        Console.Write($"{symbolTwo}{new string(symbolOne, leftOrRight)}");
        Console.WriteLine($"{symbolTwo}{new string(symbolOne, leftOrRight)}{symbolTwo}");
        center = 1;

        for (int i = 1; i < number; i++)
        {
            leftOrRight = ((number * 4 + 1) - (i * 2) - center - 4) / 2;

            Console.Write($"{new string(symbolOne, i)}{symbolTwo}");
            Console.Write($"{new string(symbolOne, leftOrRight)}{symbolTwo}");
            Console.Write($"{new string(symbolOne, center)}{symbolTwo}");
            Console.Write($"{new string(symbolOne, leftOrRight)}{symbolTwo}");
            Console.WriteLine($"{new string(symbolOne, i)}");
            center += 2;
            leftOrRight -= 2;
        }

        center = number * 4 + 1;

        Console.Write($"{new string(symbolOne, number)}{symbolTwo}");
        Console.Write($"{new string(symbolOne, center - (number * 2) - 2)}");
        Console.WriteLine($"{symbolTwo}{new string(symbolOne, number)}");
    }
}