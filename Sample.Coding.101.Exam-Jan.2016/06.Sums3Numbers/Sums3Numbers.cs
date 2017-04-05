using System;
class Sums3Numbers
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a + b == c)
        {
            if (a < b)
            {
                Console.WriteLine("{0} + {1} = {2}", a, b, c);
            }
            else
            {
                Console.WriteLine("{0} + {1} = {2}", b, a, c);
            }
        }
        if (a + c == b)
        {
            if (a < c)
            {
                Console.WriteLine("{0} + {1} = {2}", a, c, b);
            }
            else
            {
                Console.WriteLine("{0} + {1} = {2}", c, a, b);
            }
        }
        if (b + c == a)
        {
            if (b < c)
            {
                Console.WriteLine("{0} + {1} = {2}", b, c, a);
            }
            else
            {
                Console.WriteLine("{0} + {1} = {2}", c, b, a);
            }
        }
        if ((b + c != a) && (a + c != b) && (a + b != c))
        {
            Console.WriteLine("No");
        }

    }
}