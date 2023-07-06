using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
       List<int> numbers = new List<int>();

        
       Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
       int input;

       do
       {
        Console.Write("Enter number: ");
        input = int.Parse(Console.ReadLine());
        numbers.Add(input);
       } while (input != 0);

        // compute the sum
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        Console.WriteLine($"The sum is: {total}");

        // compute the average
        double average = ((double)total) / (numbers.Count);
        average = Math.Round(average, 3);
        Console.WriteLine($"The average is: {average}");

        // find the maximum number
        int largestNumber = numbers.Max();
        Console.WriteLine($"The largest number is: {largestNumber}");

        // find the smallest positive number closest to 0
       int smallestPositive = numbers.Where(i => i > 0).DefaultIfEmpty(int.MinValue).Min();
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        // sort list
        numbers.Sort();
        Console.WriteLine("Sorted Numbers: ");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    

        


        
    }
}