using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int input;

        do {
            Console.Write("Enter a number (0 to quit): ");
            input = int.Parse(Console.ReadLine());
            if (input != 0) {
                numbers.Add(input);
            }

        } while (input!=0);

        int sum = 0;
        int max = int.MinValue;
        foreach (int number in numbers) {
            sum += number;
            if (number > max) {
                max = number;
            }
        }

        float average = sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");



        
    }
}