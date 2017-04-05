using System;
class LettersCombinations
{
    static void Main()
    {
        char lineOne = char.Parse(Console.ReadLine());
        char lineTwo = char.Parse(Console.ReadLine());
        char lineThree = char.Parse(Console.ReadLine());

        int count = 0;
        for (int i = lineOne; i <= lineTwo; i++)
        {
            for (int i2 = lineOne; i2 <= lineTwo; i2++)
            {
                for (int i3 = lineOne; i3 <= lineTwo; i3++)
                {
                    if (i != lineThree && i2 != lineThree && i3 != lineThree)
                    {
                        Console.Write(Convert.ToChar(i));
                        Console.Write(Convert.ToChar(i2));
                        Console.Write(Convert.ToChar(i3) + " ");
                        count++;
                    }
                }
            }
        }
        Console.WriteLine($"{count}");
    }
}