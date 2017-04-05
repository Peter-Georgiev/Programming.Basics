using System;
using System.Collections.Generic;

class PhoneProcesses
{
    static void Main()
    {
        string batteryInput = Console.ReadLine();
        int batteryState = int.Parse(batteryInput.Remove(batteryInput.Length - 1));
        string endOfInput = "end";
        string input = "";

        List<int> appRequirements = new List<int>();

        while ((input = Console.ReadLine().ToLower()) != endOfInput)
        {
            int battery = int.Parse(input.Substring(input.Length - 3, 2));
            appRequirements.Add(battery);
        }
        int currentIndex = 0;
        while (currentIndex <= appRequirements.Count)
        {
            bool phoneOff = batteryState <= 0;
            bool needsRecharge = batteryState <= 15;
            bool insideRange = currentIndex < appRequirements.Count;
            if (phoneOff)
            {
                Console.WriteLine("Phone Off"); break;
            }
            else if (currentIndex >= appRequirements.Count && !needsRecharge)
                Console.WriteLine("Successful complete -> {0}%", batteryState);
            else if (needsRecharge)
            {
                Console.WriteLine("Connect charger -> {0}%", batteryState);
                Console.WriteLine("Programs left -> {0}", appRequirements.Count - currentIndex);
                break;
            }
            else if (insideRange)
                batteryState -= appRequirements[currentIndex];

            currentIndex++;
        }
    }
}