using System;

class Vacation
{
    static void Main()
    {
        int grownPeople = int.Parse(Console.ReadLine());
        int student = int.Parse(Console.ReadLine());
        int numberOfNights = int.Parse(Console.ReadLine());
        string modeOfTransport = Console.ReadLine();

        int grownPeopleOfNight = grownPeople * numberOfNights;
        int studentOfNight = student * numberOfNights;
        decimal transportStudent = 0, transportGrownPeople = 0;

        decimal hotel = numberOfNights * 82.99m;

        switch (modeOfTransport)
        {
            case "train":
                transportStudent = student * 14.99m * 2m;
                transportGrownPeople = grownPeople * 24.99m * 2m;
                break;
            case "bus":
                transportStudent = student * 28.50m * 2m;
                transportGrownPeople = grownPeople * 32.50m * 2m;
                break;
            case "boat":
                transportStudent = student * 39.99m * 2m;
                transportGrownPeople = grownPeople * 42.99m * 2m;
                break;
            case "airplane":
                transportStudent = student * 50.00m * 2m;
                transportGrownPeople = grownPeople * 70.00m * 2m;
                break;
            default:
                break;
        }

        decimal transportPrice = transportGrownPeople + transportStudent;
        
        if (grownPeople + student >= 50 && modeOfTransport.Equals("train"))
        {
            transportPrice = transportPrice - (transportPrice * 0.50m);
        }

        decimal commission = (transportPrice + hotel) * 0.10m;
        decimal result = transportPrice + hotel + commission;

        Console.WriteLine($"{result:F2}");
    }
}