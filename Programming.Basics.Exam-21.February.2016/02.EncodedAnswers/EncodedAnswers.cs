using System;
class EncodedAnswers
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        uint[] numQuestions = new uint[n];
        for (int i = 0; i < numQuestions.Length; i++)
        {
            numQuestions[i] = uint.Parse(Console.ReadLine());
        }
        uint a = 0, b = 0, c = 0, d = 0;
        for (int i = 0; i < numQuestions.Length; i++)
        {
            uint divisible = numQuestions[i] % 4;
            char answer = ' ';

            switch (divisible)
            {
                case 0:
                    answer = 'a';
                    a++;
                    break;
                case 1:
                    answer = 'b';
                    b++;
                    break;
                case 2:
                    answer = 'c';
                    c++;
                    break;
                case 3:
                    answer = 'd';
                    d++;
                    break;
                default:
                    break;
            }
            Console.Write($"{answer} ");
        }
        Console.WriteLine($"\nAnswer A: {a}");
        Console.WriteLine($"Answer B: {b}");
        Console.WriteLine($"Answer C: {c}");
        Console.WriteLine($"Answer D: {d}");
    }
}