using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine(); // Read the first name from the console
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine(); // Read the last name from the console
        Console.WriteLine(); // Add an empty line
        Console.WriteLine($"Your name is {lastName.capitalize}, {firstName} {lastName}."); // Print the full name to the console
    }
}