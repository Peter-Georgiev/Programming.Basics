using System;
class Bricks
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number (x, w, m):");
        Console.Write("Enter the number 'X': ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Enter the number 'W': ");
        int w = int.Parse(Console.ReadLine());
        Console.Write("Enter the number 'M': ");
        int m = int.Parse(Console.ReadLine());

        double move = 0;
        if (x % (w * m) == 0)
        {
            move = x / (w * m);
        }
        else if (x % (w * m) != 0)
        {
            move = (x / (w * m)) + 1;
        }
        Console.WriteLine($"The minimum number of courses: {move}");
    }
}