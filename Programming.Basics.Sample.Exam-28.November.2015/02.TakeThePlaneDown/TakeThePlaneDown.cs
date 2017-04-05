using System;
class TakeThePlaneDown
{
    static void Main()
    {
        int headquarterOfX = int.Parse(Console.ReadLine());
        int headquarterOfY = int.Parse(Console.ReadLine());
        int distHeadquarterBorder = int.Parse(Console.ReadLine());
        int approachingPlanes = int.Parse(Console.ReadLine());
        int[] coordinatePlanes = new int[approachingPlanes * 2 + 1];

        for (int i = 1; i < coordinatePlanes.Length; i++)
        {
            coordinatePlanes[i] = int.Parse(Console.ReadLine());
        }

        int x = 0, y = 0;

        for (int i = 1; i < coordinatePlanes.Length - 1; i++)
        {
            if (i % 2 != 0) //odd
            {
                int distanceX = headquarterOfX - coordinatePlanes[i];
                int distanceY = headquarterOfY - coordinatePlanes[i + 1];
                double distanceToPlane = Math.Sqrt((distanceX * distanceX) + (distanceY * distanceY));

                if (distHeadquarterBorder >= distanceToPlane)
                {
                    x = coordinatePlanes[i];
                    y = coordinatePlanes[i + 1];
                    Console.WriteLine($"You destroyed a plane at [{x},{y}]");
                }

                else
                {
                    //Console.WriteLine($"");
                }
            }     
        }
    }
}