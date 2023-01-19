using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your grade percentage?: ");
        string numberInText = Console.ReadLine() ?? "";
        int percentage = int.Parse(numberInText);
        

        if (percentage > 89 )
        {
            Console.WriteLine("You have an 'A' in this class.");
        }
        else if (percentage > 79 || percentage < 90)
        {
            Console.WriteLine("You have a 'B' in this class.");
        }
        else if (percentage > 69 || percentage < 80)
        {
            Console.WriteLine("You have a 'C' in this class.");
        }
        else if (percentage > 59 || percentage < 70)
        {
            Console.WriteLine("You have a 'D' in this class");
        }
        else if (percentage < 60)
        {
            Console.WriteLine("You have an 'F' in this class D:");
        }
    }
}