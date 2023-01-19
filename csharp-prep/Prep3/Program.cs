using System;

class Program
{
    static void Main(string[] args)
    {
        Random generator = new Random();
        int magicNumber = generator.Next(1, 101);

        bool keepPlaying = true;

        while(keepPlaying) {
            Console.Write("Guess a number between 1 and 100: ");
            string userGuess = Console.ReadLine() ?? "";
            int userNumber = int.Parse(userGuess);

            if (magicNumber == userNumber) {
                Console.WriteLine("Nice you guessed it!");
                keepPlaying = false;
            } else if (magicNumber>userNumber) {
                Console.WriteLine("Higher");
            } else {
                Console.WriteLine("Lower");
            }
        }
    }
}