using System;

public class Program
{
    public static void Main()
    {
        
        //create an object
    Scripture scripture = new Scripture("John", 3, 16, "For God so loved the world that he gave his only son, that whosoever believeth in him should not perish, but have everlasting life. ");  
    
    while(true){
        scripture.Display();
        Console.ReadLine();
        scripture.HideRandomWord();
    }
    }
}

    



