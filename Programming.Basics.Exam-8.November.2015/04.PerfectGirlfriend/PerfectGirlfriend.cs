using System;
using System.Collections.Generic;

class PerfectGirlfriend
{
    static void Main()
    {
        List<string> messages = new List<string>();
        int perfectGirls = 0;

        string inline = Console.ReadLine();

        while (inline != "Enough dates!")
        {
            string[] info = inline.Split('\\');

            string phoneNumber = info[1];
            int sumPhNum = 0;
            for (int i = 0; i < phoneNumber.Length; i++)
            {
                sumPhNum += int.Parse(phoneNumber[i].ToString());
            }            
            
            switch (info[0])
            {
                case "Monday":
                    sumPhNum += 1;
                    break;
                case "Tuesday ":
                    sumPhNum += 2;
                    break;
                case "Wednesday":
                    sumPhNum += 3;
                    break;
                case "Thursday":
                    sumPhNum += 4;
                    break;
                case "Friday":
                    sumPhNum += 5;
                    break;
                case "Saturday":
                    sumPhNum += 6;
                    break;
                case "Sunday":
                    sumPhNum += 7;
                    break;
                default:
                    break;
            }

            string convertSizeBra = info[2];
            string size = convertSizeBra.Substring(0, convertSizeBra.Length - 1);
            int sizeInt = int.Parse(size);
            char bra = convertSizeBra[convertSizeBra.Length - 1];

            int braSize = sizeInt * bra;

            string convertNameFirstChar = info[3];
            int nameLength = info[3].Length;
            char nameFirstChar = convertNameFirstChar[0];
            int name = nameFirstChar * nameLength;

            int result = sumPhNum + braSize - name;

            if (result > 6000)
            {
                messages.Add(info[3] + " is perfect for you.");
                perfectGirls++;
            }
            else
            {
                messages.Add("Keep searching, " + info[3] + " is not for you.");
            }

            inline = Console.ReadLine();
        }

        foreach (string item in messages)
        {
            Console.WriteLine(item);
        }        
        Console.WriteLine(perfectGirls);
    }
}