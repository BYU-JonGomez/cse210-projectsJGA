using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your score: ");
        int score = int.Parse(Console.ReadLine());

        string letter = "";
        string sign = "";

        if (score >= 90)
        {
            letter = "A";
            if (score < 93)
            {
                sign = "-";
            }
        }
        else if (score >= 80)
        {
            letter = "B";
            if (score % 10 >= 7)
            {
                sign = "+";
            }
            else if (score % 10 < 3)
            {
                sign = "-";
            }
        }
        else if (score >= 70)
        {
            letter = "C";
            if (score % 10 >= 7)
            {
                sign = "+";
            }
            else if (score % 10 < 3)
            {
                sign = "-";
            }
        }
        else if (score >= 60)
        {
            letter = "D";
            if (score % 10 >= 7)
            {
                sign = "+";
            }
            else if (score % 10 < 3)
            {
                sign = "-";
            }
        }
        else
        {
            letter = "F";
        }

        // Handle special cases for A+ and F+ or F-
        if (letter == "A" && sign == "+")
        {
            sign = ""; // No A+
        }
        if (letter == "F")
        {
            sign = ""; // No F+ or F-
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (score >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't give up! Better luck next time.");
        }
    }
}