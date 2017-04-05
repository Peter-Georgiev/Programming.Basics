using System;
class TheBetterMusicProducer
{
    static void Main()
    {
        int albumsInEurope = int.Parse(Console.ReadLine());
        decimal albumInEuro = decimal.Parse(Console.ReadLine()) * 1.94m;
        int albumsInNorthAmerica = int.Parse(Console.ReadLine());
        decimal albumsInDollars = decimal.Parse(Console.ReadLine()) * 1.72m;
        int albumsInSouthAmerica = int.Parse(Console.ReadLine());
        decimal albumInPesos = decimal.Parse(Console.ReadLine()) / 332.74m;
        int numberOfConcerts = int.Parse(Console.ReadLine());
        decimal singleConcertInEuro = decimal.Parse(Console.ReadLine()) * 1.94m;

        decimal inEurope = albumsInEurope * albumInEuro;
        decimal inNorthAmerica = albumsInNorthAmerica * albumsInDollars;
        decimal inSouthAmerica = albumsInSouthAmerica * albumInPesos;
        decimal albumsAll = inEurope + inNorthAmerica + inSouthAmerica;
        albumsAll = albumsAll - (albumsAll * 0.35m);
        albumsAll = albumsAll - (albumsAll * 0.20m);

        decimal concertsProfit = numberOfConcerts * singleConcertInEuro;

        if (concertsProfit > 100000)
        {
            concertsProfit = concertsProfit - (concertsProfit * 0.15m);
        }        

        if (concertsProfit >= albumsAll)
        {
            Console.WriteLine($"On the road again! We'll see the world and earn {concertsProfit:F2}lv.");
        }
        else
        {
            Console.WriteLine($"Let's record some songs! They'll bring us {albumsAll:F2}lv.");
        }
    }
}