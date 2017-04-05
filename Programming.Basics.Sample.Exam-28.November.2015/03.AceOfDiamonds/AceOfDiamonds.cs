using System;
class AceOfDiamonds
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('*', n));

        for (int count = 0, at = 1, dash;
            count <= n / 2 - 1; count++)
        {
            dash = (n - at - 2) / 2;
            Console.Write("*" + new string('-', dash));
            Console.Write(new string('@', at));
            Console.WriteLine(new string('-',dash) + "*");
            at += 2;
        }

        for (int count = 0, dash = 1;
            count < n / 2 - 1; count++)
        {
            int at = n - 2 - (2 * dash);
            Console.Write("*" + new string('-', dash));
            Console.Write(new string('@', at));
            Console.WriteLine(new string('-', dash) + "*");
            dash++;
        }

        Console.WriteLine(new string('*', n));
    }
}