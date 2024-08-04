using System;

class Program
{
    static void Main()
    {
        // Use a loop to iterate from 0 to 98
        for (int i = 0; i <= 98; i++)
        {
            // Print the number in decimal and hexadecimal format
            // Using the format string "{0} = 0x{1:X}" to format the output
            Console.WriteLine($"{i} = 0x{i:X}");
        }
    }
}
