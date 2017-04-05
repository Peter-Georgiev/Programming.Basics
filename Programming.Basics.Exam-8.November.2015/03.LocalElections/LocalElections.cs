using System;
class LocalElections
{
    static void Main()
    {
        int count = 1;

        int number = int.Parse(Console.ReadLine());
        int vote = int.Parse(Console.ReadLine());
        char symbol = char.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++, count++)
        {
            Console.WriteLine(new string('.', 13));
            Console.WriteLine("...+-----+...");
            
            if (vote == i)
            {
                if (char.ToLower(symbol) == 'x')
                {
                    Console.WriteLine("...|.\\./.|...");
                    Console.WriteLine($"{count:00}.|..X..|...");
                    Console.WriteLine("...|./.\\.|...");
                }
                else
                {
                    Console.WriteLine("...|\\.../|...");
                    Console.WriteLine($"{count:00}.|.\\./.|...");
                    Console.WriteLine("...|..V..|...");
                }
            }
            else
            {
                Console.WriteLine("...|.....|...");
                Console.WriteLine($"{count:00}.|.....|...");
                Console.WriteLine("...|.....|...");
            }
            
            Console.WriteLine("...+-----+...");
        }
        Console.WriteLine(new string('.', 13));
    }
}