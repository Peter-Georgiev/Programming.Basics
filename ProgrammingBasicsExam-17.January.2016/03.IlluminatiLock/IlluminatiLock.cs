using System;
class IlluminatiLock
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.Write(new string('.', n));
        Console.Write(new string('#', n));
        Console.WriteLine(new string('.', n));

        int top = n;
        int center = 0;

        for (; center < n - 2; center += 2)
        {
            top -= 2;
            Console.Write(new string('.', top) + "##");
            Console.Write(new string('.', center) + "#");
            Console.Write(new string('.', n - 2) + "#");
            Console.Write(new string('.', center) + "##");
            Console.WriteLine(new string('.', top));
        }

        center -= 2;

        for (; center >= 0; center -= 2)
        {
            Console.Write(new string('.', top) + "##");
            Console.Write(new string('.', center) + "#");
            Console.Write(new string('.', n - 2) + "#");
            Console.Write(new string('.', center) + "##");
            Console.WriteLine(new string('.', top));
            top += 2;
        }

        Console.Write(new string('.', n));
        Console.Write(new string('#', n));
        Console.WriteLine(new string('.', n));
    }
}