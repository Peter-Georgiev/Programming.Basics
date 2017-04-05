using System;
class PassionDays
{
    static void Main()
    {
        string commandMall = "";
        double moneyBeforeEnter = 0;
        bool mallEnter = commandMall == "mall.Enter";
        bool mallExit = commandMall == "mall.Exit";

        while (mallEnter != true && mallExit != true)
        {
            commandMall = Console.ReadLine();
            if (commandMall.Contains("mall.Enter"))
            {
                mallEnter = true;
            }
            else if (commandMall.Contains("mall.Exit"))
            {
                mallExit = true;
            }
            else
            {
                moneyBeforeEnter += Convert.ToDouble(commandMall);
            }
        }

        char character = ' ';
 

        double discount;
        double money = 0.00;
        double purchases = 0.00;
        

        while (mallExit != true)
        {
            commandMall = Console.ReadLine();
            
            if (commandMall.Contains("mall.Exit"))
            {
                mallExit = true;
            }

            else
            {
                character = Convert.ToChar(commandMall);

                bool uppercaseLetter = 'A' <= character && character <= 'Z';
                bool lowercase = 'a' <= character && character <= 'z';
                bool percent = '%' == character;
                bool star = '*' == character;

                if (uppercaseLetter || lowercase || percent)
                {
                    if (star)
                    {
                        money += moneyBeforeEnter + 10;
                    }
                    if (uppercaseLetter)
                    {
                        discount = Convert.ToChar(character) * 0.5;
                        discount = Convert.ToChar(character) - discount;
                        money += moneyBeforeEnter - discount;
                        purchases++;
                    }
                    if (lowercase)
                    {
                        discount = Convert.ToChar(character) * 0.7;
                        discount = Convert.ToChar(character) - discount;
                        money += moneyBeforeEnter - discount;
                        purchases++;
                    }
                    if (percent)
                    {
                        money += moneyBeforeEnter / 2;
                        purchases++;
                    }
                }
                else
                {
                    purchases++;
                }
            }
        }

        if (money <= moneyBeforeEnter)
        {
            Console.WriteLine($"{purchases} purchases. Money left: {money:F2} lv.");
        }
        else
        {
            Console.WriteLine($"No purchases. Money left: {money:F2} lv.");
        }
    }
}