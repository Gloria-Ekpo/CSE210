﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Book mistborn = new Book("Mistborn","Brandon Sanderson");

mistborn.Display();
Console.WriteLine(mistborn.IsAvailable());

Book americanah = new Book("Americanah", "Gladys Gopeh");
americanah.Display();