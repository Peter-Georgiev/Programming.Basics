using System;
class Axe
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());

        int leftDashes = numberN * 3;
        int star;
        int centerDashes = 0;
        int rightDashes = numberN * 5 - leftDashes - 2;
        for (int i = 0; i < numberN; i++)
        {
            Console.WriteLine($"{new string('-', leftDashes)}{"*"}{new string('-', centerDashes)}{"*"}{new string('-', rightDashes)}");

            rightDashes--;
            centerDashes++;
        }

        star = numberN * 3 + 1;
        centerDashes--;
        rightDashes++;

        for (int i = 0; i < numberN / 2; i++)
        {
            Console.WriteLine($"{new string('*', star)}{new string('-', centerDashes)}{"*"}{new string('-', rightDashes)}");
        }

        for (int i = 1; i < numberN / 2; i++)
        {
            Console.WriteLine($"{new string('-', leftDashes)}{"*"}{new string('-', centerDashes)}{"*"}{new string('-', rightDashes)}");

            leftDashes--;
            centerDashes += 2;
            rightDashes--;
        }

        Console.WriteLine($"{new string('-', leftDashes)}{new string('*', numberN * 5 - leftDashes - rightDashes)}{new string('-', rightDashes)}");
    }
}