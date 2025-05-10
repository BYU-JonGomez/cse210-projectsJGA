using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;

        while (playAgain)
        {
            int magicnumber = random.Next(1, 101);
            int guessnumber = 0;
            int attempts = 0;

            Console.WriteLine("I have picked a magic number between 1 and 100. Can you guessnumber it?");

            while (guessnumber != magicnumber)
            {
                Console.Write("What is your guess? ");
                guessnumber = int.Parse(Console.ReadLine());
                attempts++;

                if (guessnumber < magicnumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guessnumber > magicnumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! It took you {attempts} attempts.");
                }
            }

            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();
            playAgain = response == "yes";
        }
    }
}