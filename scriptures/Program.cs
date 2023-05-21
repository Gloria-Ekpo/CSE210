// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

class Word
{
    public string Text { get; }
    public bool Hidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        Hidden = false;
    }

    public void Hide()
    {
        Hidden = true;
    }

    public override string ToString()
    {
        return Hidden ? "______" : Text;
    }
}

