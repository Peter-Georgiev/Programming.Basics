using System;
class Logistics
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arrayLoad = new int[n];
        for (int i = 0; i < arrayLoad.Length; i++)
        {
            arrayLoad[i] = int.Parse(Console.ReadLine());
        }

        double ollLoad = 0, perTon = 0;
        double van = 0, truk = 0, train = 0;
        for (int i = 0; i < arrayLoad.Length; i++)
        {
            ollLoad += arrayLoad[i];
            if (arrayLoad[i] >= 12)
            {
                train += arrayLoad[i];
                perTon += arrayLoad[i] * 120;
            }
            else if (arrayLoad[i] >= 4 && arrayLoad[i] <= 11)
            {
                truk += arrayLoad[i];
                perTon += arrayLoad[i] * 175;
            }
            else if (arrayLoad[i] <= 3)
            {
                van += arrayLoad[i];
                perTon += arrayLoad[i] * 200;
            }
        }
        perTon = perTon / ollLoad;
        van = van / ollLoad * 100;
        truk = truk / ollLoad * 100;
        train = train / ollLoad * 100;

        Console.WriteLine($"{perTon:F2}\n{van:F2}%\n{truk:F2}%\n{train:F2}%");
    }
}