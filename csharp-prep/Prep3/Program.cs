using System;

class Program
{
    static void Main(string[] args)
    {
      Random random = new Random();
      int magicNumber = random.Next(1, 101);
      int guess = -1;
  
      // Console.Write("What is the magic number ?");
      // int number =int.Parse(Console.ReadLine());


    while (guess != magicNumber)
    {


      Console.Write("What is your guess ");
      guess = int.Parse(Console.ReadLine());

      if (magicNumber > guess)
      {
        Console.WriteLine("Higher");
      }

      else if (magicNumber < guess)
      {
          Console.WriteLine("Lower");
      }
      else 
      {
        Console.WriteLine("You guesses it! ");
        
      }

    }   
    }
}