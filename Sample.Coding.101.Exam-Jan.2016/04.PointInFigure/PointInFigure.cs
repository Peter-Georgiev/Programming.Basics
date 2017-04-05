using System;
class PointInFigure
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number 'X': ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Enter the number 'Y': ");
        int y = int.Parse(Console.ReadLine());

        int[] xFigure = new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        int[] yFigure = new int[] { -5, -4, -3, -2, -1, 0, 1, 2, 3 };
        int[] noX = new int[] { 2, 3, 11, 12 };
        int[] noY = new int[] { -5, -4, 2, 3 };

        int tempX = 1001, tempY = -1001;

        for (int i = 0; i < xFigure.Length; i++)
        {
            xFigure[i] = xFigure[i];
            if (xFigure[i] == x)
            {
                tempX = x;
                break;
            }
        }
        for (int i = 0; i < yFigure.Length; i++)
        {
            yFigure[i] = yFigure[i];
            if (yFigure[i] == y)
            {
                tempY = y;
                break;
            }
        }

        for (int i = 0; i < noX.Length; i++)
        {
            noX[i] = noX[i];

            if (noX[i] == x)
            {
                for (int j = 0; j < noY.Length; j++)
                {
                    noY[j] = noY[j];
                    if (noY[j] == y)
                    {
                        tempX = 1001;
                        tempY = -1001;
                        break;
                    }
                }
            }
        }

        if ((tempX != 1001) && (tempY != -1001))
        {
            Console.WriteLine("in");
        }
        else
        {
            Console.WriteLine("out");
        }
    }
}