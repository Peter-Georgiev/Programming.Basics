using System;
class HotelRoom
{
    static void Main()
    {
        string mounth = Console.ReadLine();
        int numberOfNight = int.Parse(Console.ReadLine());

        string season = "";
        double apartment = 0, studio = 0;
        switch (mounth)
        {
            case "May": season = "seasonOne"; break;
            case "June": season = "seasonTwo"; break;
            case "July": season = "seasonThree"; break;
            case "August": season = "seasonThree"; break;
            case "September": season = "seasonTwo"; break;
            case "October": season = "seasonOne"; break;
        }
        if (season == "seasonOne")
        {
            studio = numberOfNight * 50;
            apartment = numberOfNight * 65;
            if (numberOfNight > 14)
            {
                studio = numberOfNight * (50 * 0.7);
                apartment = numberOfNight * (65 * 0.9);
            }
            else if (numberOfNight > 7)
            {
                studio = numberOfNight * (50 * 0.95);
            }
        }
        else if (season == "seasonTwo")
        {
            studio = numberOfNight * 75.20;
            apartment = numberOfNight * 68.70;
            if (numberOfNight > 14)
            {
                studio = numberOfNight * (75.20 * 0.8);
                apartment = numberOfNight * (68.70 * 0.9);
            }
        }
        else if (season == "seasonThree")
        {
            studio = numberOfNight * 76;
            apartment = numberOfNight * 77;
            if (numberOfNight > 14)
            {
                apartment = numberOfNight * (77 * 0.9);
            }
        }

        Console.WriteLine($"Apartment: {apartment:F2} lv.");
        Console.WriteLine($"Studio: {studio:F2} lv.");
    }
}