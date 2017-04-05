using System;
class FallenInLove
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int pointLeftOrRight = n * 2;
        int centerPoint = n * 2;
        Console.Write($"##{new string('.', centerPoint)}#");
        Console.WriteLine($"#{new string('.', centerPoint)}##");
        int leftOrRight = 0;
        int hashtag = 1;
        for (int i = 1; i < n; i++)
        {
            pointLeftOrRight -= 2;
            leftOrRight = i;
            centerPoint = i * 2;
            Console.Write($"#{new string('~', leftOrRight)}#");
            Console.Write($"{new string('.', pointLeftOrRight)}");
            Console.Write($"{new string('#', hashtag)}");
            Console.Write($"{new string('.', centerPoint)}");
            Console.Write($"{new string('#', hashtag)}");
            Console.Write($"{new string('.', pointLeftOrRight)}");
            Console.WriteLine($"#{new string('~', leftOrRight)}#");
        }
        pointLeftOrRight = 1;
        centerPoint = n * 2;
        for (int i = n; i >= 0; i--)
        {

            leftOrRight = i;
            Console.Write($"{new string('.', pointLeftOrRight)}");
            Console.Write($"#{new string('~', leftOrRight)}#");
            Console.Write($"{new string('.', centerPoint)}");
            Console.Write($"#{new string('~', leftOrRight)}#");
            Console.WriteLine($"{new string('.', pointLeftOrRight)}");
            centerPoint -= 2;
            pointLeftOrRight += 2;
        }
        pointLeftOrRight = n * 2;
        for (int i = 1; i <= n; i++)
        {
            Console.Write($".{new string('.', pointLeftOrRight)}.#");
            Console.WriteLine($"#.{new string('.', pointLeftOrRight)}.");
        }

    }
}