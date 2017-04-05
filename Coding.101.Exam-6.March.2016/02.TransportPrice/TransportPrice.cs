using System;
class TransportPrice
{
    static void Main()
    {
        int kilometer = int.Parse(Console.ReadLine());
        string dayNight = Console.ReadLine();

        double result = 0;
        if (kilometer < 20)
        {
            if (dayNight == "day")
            {
                result = 0.70 + kilometer * 0.79;
            }
            else
            {
                result = 0.70 + kilometer * 0.90;
            }
        }
        if ((kilometer >= 20) && (kilometer < 100))
        {
            if (dayNight == "day")
            {
                result = kilometer * 0.09;
            }
            else
            {
                result = kilometer * 0.09;
            }
        }
        else if (kilometer >= 100)
        {
            if (dayNight == "day")
            {
                result = kilometer * 0.06;
            }
            else
            {
                result = kilometer * 0.06;
            }
        }
        Console.WriteLine(Math.Round(result, 2));
    }
}