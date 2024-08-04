using System;

class Program
{
    static void Main()
    {
        string result = "";

        for (int i = 0; i <= 9; i++)
        {
            for (int j = i + 1; j <= 9; j++)
            {
                result += i.ToString("D1") + j.ToString("D1");

                if (!(i == 8 && j == 9))
                {
                    result += ", ";
                }
            }
        }

        Console.WriteLine(result);
    }
}
