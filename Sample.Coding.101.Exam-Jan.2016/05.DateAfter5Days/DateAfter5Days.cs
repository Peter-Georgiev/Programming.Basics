using System;
class DateAfter5Days
{
    static void Main(string[] args)
    {
        int d = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        int five = 5, tempday = 0, day = 0, month = 0;
        int[] tempMonth;
        tempMonth = new int[0];
        switch (m)
        {
            case 01: tempMonth = new int[31]; break; //january = new int[31];
            case 02: tempMonth = new int[28]; break; //fevruary = new int[28];
            case 03: tempMonth = new int[31]; break; //march = new int[31];
            case 04: tempMonth = new int[30]; break; //april = new int[30];
            case 05: tempMonth = new int[31]; break; //may = new int[31];
            case 06: tempMonth = new int[30]; break; //june = new int[30];
            case 07: tempMonth = new int[31]; break; //july = new int[31];
            case 08: tempMonth = new int[31]; break; //august = new int[31];
            case 09: tempMonth = new int[30]; break; //september = new int[30];
            case 10: tempMonth = new int[31]; break; //october = new int[31];
            case 11: tempMonth = new int[30]; break; //november = new int[30];
            case 12: tempMonth = new int[31]; break; //december = new int[31];
        }
        for (int i = 1; i <= (d + five); tempday++, i++)
        {
            if (i > tempMonth.Length)
            {
                day = (d + five) - tempMonth.Length;
                month = m + 1;
                if (month > 12)
                {
                    month = 1;
                    break;
                }
                break;
            }
            tempMonth[tempday] = i;
            day = tempMonth[tempday];
            month = m;
        }
        Console.WriteLine("{0}.{1:00}", day, month);
    }
}