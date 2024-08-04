using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        double percent = 0.7553;
        double currency = 98765.43;
        Console.WriteLine($"Percent: {percent:P2} tip");
        Console.WriteLine($"Currency: {currency:C2}");
    }
}