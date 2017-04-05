using System;
class PointOnSegment
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number 'first': ");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Enter the number 'second': ");
        int second = int.Parse(Console.ReadLine());
        Console.Write("Enter the number 'point': ");
        int point = int.Parse(Console.ReadLine());

        if ((point >= Math.Min(first, second)) && (point <= Math.Max(first, second)))
        {
            Console.WriteLine("in");
            if (Math.Abs(point - second) < Math.Abs(point - first))
            {
                Console.WriteLine(Math.Abs(point - second));
            }
            else
            {
                Console.WriteLine(Math.Abs(point - first));
            }
        }
        else
        {
            Console.WriteLine("out");
            if (Math.Abs(point - second) < Math.Abs(point - first))
            {
                Console.WriteLine(Math.Abs(point - second));
            }
            else
            {
                Console.WriteLine(Math.Abs(point - first));
            }
        }
    }
}