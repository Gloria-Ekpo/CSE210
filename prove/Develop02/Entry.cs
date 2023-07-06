using System;

class Entry
{
    string _text;
    string _name;
    string _date;
    string _location;
    public Entry(string text, string name, string date, string location) {
        _text = text;
        _name = name;
        _date = date;
        _location = location;
    }

    public void DisplayEntry()
    {
        Console.Write("Printing entry...");
        Console.Write("text:"+ this._text);
    }

    public void SaveEntry()
    {
        // save current entrys
    }
}