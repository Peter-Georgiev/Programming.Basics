using System;
class SaltAndPepper
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        string commandLine = "";

        while (commandLine != "end")
        {
            commandLine = Console.ReadLine();
            string[] comandArray = commandLine.Split(' ');
            string saltOrPepper = "";
            int stepLine = 0;

            try
            {
                if (commandLine != "end")
                {
                    saltOrPepper = comandArray[0];
                    stepLine = Convert.ToInt16(comandArray[1]);
                }
            }
            catch (Exception)
            {
                commandLine = "";
            }

            if (saltOrPepper == "salt")
            {
                for (int i = 0; i < 63; i += stepLine)
                {
                    if (((number >> i) & 1) == 1)
                    {
                        ulong mask = ~((ulong)1 << i);
                        number = number & mask;
                    }
                }
            }

            else if (saltOrPepper == "pepper")
            {
                for (int i = 0; i < 63; i += stepLine)
                {
                    if (((number >> i) & 1) == 0)
                    {
                        ulong mask = ((ulong)1 << i);
                        number = number | mask;
                    }
                }
            }
        }
        Console.WriteLine(number);
    }
}