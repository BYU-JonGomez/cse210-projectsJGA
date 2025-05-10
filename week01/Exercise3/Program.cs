using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number? ");
        int magicnumber = int.Parse(Console.ReadLine());
        Console.WriteLine("what is your guess? ");
        int guessnumber = int.Parse(Console.ReadLine());

        if (magicnumber == guessnumber)
        {
            Console.WriteLine("You guessed it!");
        }
        while (magicnumber != guessnumber)
        {
            Console.WriteLine("what is your guess? ");
            guessnumber = int.Parse(Console.ReadLine());
            if (magicnumber > guessnumber)
            {
                Console.WriteLine("Try higher");
            }
            else if (magicnumber < guessnumber)
            {
                Console.WriteLine("Try lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                break;
            }
        }
    }
}