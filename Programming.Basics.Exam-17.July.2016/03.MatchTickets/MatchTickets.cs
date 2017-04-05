using System;
class MatchTickets
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string category = Console.ReadLine();
        int people = int.Parse(Console.ReadLine());

        double residueBudget = 0;
        if (people >= 50)
        {
            residueBudget = budget * 0.75;
        }
        else if (people >= 25 && people <= 49)
        {
            residueBudget = budget * 0.6;
        }
        else if (people >= 10 && people <= 24)
        {
            residueBudget = budget * 0.5;
        }
        else if (people >= 5 && people <= 9)
        {
            residueBudget = budget * 0.4;
        }
        else if (people >= 1 && people <= 4)
        {
            residueBudget = budget * 0.25;
        }

        double ticketVip = people * 499.99;
        double ticketNormal = people * 249.99;
        double ticket = 0;

        if (category == "Normal")
        {
            ticket = Math.Abs(ticketNormal - residueBudget);
            if (ticketNormal <= residueBudget)
            {
                Console.WriteLine($"Yes! You have {ticket:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {ticket:F2} leva.");
            }
        }
        else if (category == "VIP")
        {
            ticket = Math.Abs(residueBudget - ticketVip);
            if (ticketVip <= residueBudget)
            {
                Console.WriteLine($"Yes! You have {ticket:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {ticket:F2} leva.");
            }
        }
    }
}