using System;
using System.Collections.Generic;

class SoftUniCamp
{
    static void Main()
    {
        int numberOfGroups = int.Parse(Console.ReadLine());
        int[] peopleInGroups = new int[numberOfGroups];

        for (int i = 0; i < peopleInGroups.Length; i++)
        {
            peopleInGroups[i] = int.Parse(Console.ReadLine());
        }

        double car = 0d;
        double van = 0d;
        double miniBus = 0d;
        double largeBus = 0d;
        double train = 0d;
        int peoleAll = 0;

        for (int i = 0; i < peopleInGroups.Length; i++)
        {
            peoleAll += peopleInGroups[i];

            if (peopleInGroups[i] >= 41)
            {
                train += (double)peopleInGroups[i];

            }

            else if (peopleInGroups[i] >= 26)
            {
                largeBus += (double)peopleInGroups[i];
            }

            else if (peopleInGroups[i] >= 13)
            {
                miniBus += (double)peopleInGroups[i];
            }

            else if (peopleInGroups[i] >= 6)
            {
                van += (double)peopleInGroups[i];
            }

            else
            {
                car += (double)peopleInGroups[i];
            }
        }

        List<double> result = new List<double>();

        result.Add(car = (car / peoleAll) * 100.00d);
        result.Add(van = (van / peoleAll) * 100.00d);
        result.Add(miniBus = (miniBus / peoleAll) * 100.0d);
        result.Add(largeBus = (largeBus / peoleAll) * 100.00d);
        result.Add(train = (train / peoleAll) * 100.00d);

        foreach (var item in result)
        {
            Console.WriteLine($"{item:F2}%");
        }
    }
}