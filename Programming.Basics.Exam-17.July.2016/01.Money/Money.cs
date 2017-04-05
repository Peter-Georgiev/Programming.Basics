using System;
class Money
{
    static void Main()
    {
        int bitcoins = int.Parse(Console.ReadLine()) * 1168;
        double chinesYuan = double.Parse(Console.ReadLine());
        double commission = double.Parse(Console.ReadLine());

        double chinesYuanUsd = chinesYuan * 0.15;
        double chinesYuanBGN = chinesYuanUsd * 1.76;
        double resultBGNtoEUR = (bitcoins + chinesYuanBGN) / 1.95;
        double resultPercent = resultBGNtoEUR * commission / 100;
        double result = resultBGNtoEUR - resultPercent;
        Console.WriteLine(result);
    }
}