using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        bool addNumbers = true;

        while(addNumbers) {
            Console.Write("Enter a list of numbers, type 0 when finished.");
            string userInput = Console.ReadLine() ?? "";
            int userNumber = int.Parse(userInput);

            if (userNumber != 0){
                numbers.Add(userNumber);
            }
            else {
                addNumbers = false;
                int sumNumbers = 0;
                foreach (int number in numbers)
                {
                    sumNumbers += number;
                }
                Console.WriteLine($"The sum is:{sumNumbers}");
                int count = numbers.Count;
                int averageNumbers = sumNumbers/count;
                Console.WriteLine($"The average is: {averageNumbers}");
                int largestNumber = numbers.Max();
                Console.WriteLine($"The largest number is: {largestNumber}");

            }
        }
    }
}