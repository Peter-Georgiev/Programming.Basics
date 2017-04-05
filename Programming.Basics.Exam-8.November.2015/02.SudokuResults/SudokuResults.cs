using System;
class SudokuResults
{
    static void Main()
    {
        decimal seconds = 0;
        int countGame = 0;

        string inputTime = Console.ReadLine();
        while (inputTime != "Quit")
        {
            int min = int.Parse(inputTime.Substring(0, 2));
            int sec = int.Parse(inputTime.Substring(3, 2));
            seconds += min * 60 + sec;
            countGame++;

            inputTime = Console.ReadLine(); 
        }

        seconds /= countGame;
        string message = "Gold";

        if (seconds > 1400)
        {
            message = "Bronze";
        }
        else if (seconds >= 720)
        {
            message = "Silver";
        }

        Console.WriteLine($"{message} Star");
        
        Console.WriteLine($"Games - {countGame} \\ Average seconds - {Math.Ceiling(seconds)}");
    }
}