using System;

class DogHouse
{
    static void Main()
    {
        double lengthA = double.Parse(Console.ReadLine());
        double heightB = double.Parse(Console.ReadLine());

        double twoPages = lengthA * (lengthA / 2.00) * 2.00;
        double square = (lengthA / 2.00) * (lengthA / 2.00);
        double triangle = (lengthA / 2.00 * (heightB - lengthA / 2.00)) / 2.00;
        
        double rearWall = square + triangle;
        double input = (lengthA / 5.00) * (lengthA / 5.00);
        double frontWall = rearWall - input;
        double totalAreaOfWalls = twoPages + rearWall + frontWall;
        double greenPain = totalAreaOfWalls / 3.00;
        double roof = lengthA * (lengthA / 2.00) * 2.00;
        double redPain = roof / 5.00;

        Console.WriteLine($"{greenPain:F2}");
        Console.WriteLine($"{redPain:F2}");
    }
}