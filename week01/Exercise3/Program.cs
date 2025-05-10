using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? "); // Part 1
        // int magicnumber = int.Parse(Console.ReadLine());
        // Console.Write("What is your guess? "); // Part 2
        // int guessnumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random(); //Part 3
        int magicnumber = randomGenerator.Next(1, 101);

        int guessnumber = -1;

        while (guessnumber != magicnumber)
        {
            Console.Write("What is your guess?");
            guessnumber = int.Parse(Console.ReadLine());

            if (magicnumber == guessnumber)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (magicnumber < guessnumber)
            {
                Console.WriteLine("Try lower");
            }
            else
            {
                Console.WriteLine("Try higher!");
            }

        }

    }
}