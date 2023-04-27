using System;

class Program
{
    static void Main(string[] args)
    {
        // Call DisplayWelcome function
        DisplayWelcome();

        // Call PromptUserName function and save the returned value
        string name = PromptUserName();

        //Call PromptUserNumber function and save the return value
        int number = PromptUserNumber();

        //Call SquareNumber function with the number input and save
        int squaredNumber =  SquareNumber(number);

        //Call DisplayResult function with the name and squaredNumber inputs
        DisplayResult(name, squaredNumber);

        //wait for user input before closing console window
        Console.ReadLine();
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine("Hi {0}, the square of your number is {1}.", name, squaredNumber);
    }
}