using System;
class CakeTycoon
{
    static void Main()
    {
        //input
        ulong amountCakes = ulong.Parse(Console.ReadLine());
        decimal kilogFlourOneCake = decimal.Parse(Console.ReadLine());
        uint kilogFlour = uint.Parse(Console.ReadLine());
        uint truffles = uint.Parse(Console.ReadLine());
        uint trufflePrice = uint.Parse(Console.ReadLine());

        //body
        decimal cakes = Math.Floor((decimal)kilogFlour / kilogFlourOneCake);
        ulong trufflesCost = (ulong)(truffles) * (ulong)(trufflePrice);

        if (cakes < amountCakes)
        {

            decimal totalFlourCakes = amountCakes * kilogFlourOneCake;
            decimal kilogramsNeeded = totalFlourCakes - kilogFlour;
            Console.WriteLine($"Can make only {cakes} cakes, need {kilogramsNeeded:F2} kg more flour");
        }

        else
        {
            decimal cakePrice = ((decimal)trufflesCost) / (decimal)(amountCakes) * 1.25m;
            Console.WriteLine($"All products available, price of a cake: {cakePrice:F2}");
        }
    }
}