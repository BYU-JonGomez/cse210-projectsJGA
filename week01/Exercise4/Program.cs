using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<float> numbers = new List<float>();
        float number = -1;

        while (number != 0)
        {
            Console.Write("Enter a number: ");
            number = float.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        float sum = 0;
        foreach (float num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum / numbers.Count}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");
        
        //stretch challenge part 1
        float lowestPositive = float.MaxValue;
        foreach (float num in numbers)
        {
            if (num > 0 && num < lowestPositive)
            {
            lowestPositive = num;
            }
        }
        Console.WriteLine($"The smallest positive number is: {lowestPositive}");
        
        //stretch challenge part 2
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (float num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}