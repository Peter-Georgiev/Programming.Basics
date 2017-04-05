using System;
class TriangleArea
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number (x1, y1, x2, y2, x3, y3):");

        int[] inNumber = new int[6];
        for (int i = 0; i < inNumber.Length; i++)
        {
            inNumber[i] = int.Parse(Console.ReadLine());
            if ((-1000 >= inNumber[i]) || (inNumber[i] >= 1000))
            {
                Console.WriteLine("Invalid number [-1000.....1000]!");
                break;
            }
        }

        float a, h, s;
        if (inNumber[2] > inNumber[4])
        {
            a = inNumber[2] - inNumber[4];
        }
        else
        {
            a = inNumber[4] - inNumber[2];
        }
        if (inNumber[5] > inNumber[1])
        {
            h = inNumber[5] - inNumber[1];
        }
        else
        {
            h = inNumber[1] - inNumber[5];
        }
        s = a * h / 2;
        Console.WriteLine($"S = {s}");
    }
}