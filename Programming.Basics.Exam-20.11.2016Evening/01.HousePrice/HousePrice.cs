using System;
class HousePrice
{
    static void Main()
    {
        double smallestRoom = double.Parse(Console.ReadLine());
        double kitchen = double.Parse(Console.ReadLine());
        double priceSquareMeter = double.Parse(Console.ReadLine());

        double rootTwo = smallestRoom + (smallestRoom * 0.1);
        double roomThree = rootTwo + (rootTwo * 0.1);
        double bethroom = smallestRoom / 2;
        double area = smallestRoom + kitchen + rootTwo + roomThree + bethroom;
        area = area + (area * 0.05);
        double price = area * priceSquareMeter;

        Console.WriteLine($"{price:F2}");
    }
}