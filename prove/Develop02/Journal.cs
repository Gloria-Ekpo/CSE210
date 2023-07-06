using System;

class Journal
{
    public List<Entry> _journal;
    public Journal () {
        _journal = new List<Entry>();
    }
    

    public void DisplayJournal()
    {
        foreach (Entry entry in _journal)
        {
            entry.DisplayEntry();
        }     
    }

    public void SaveJournal(string saveFile)
    {
        foreach (Entry entry in _journal)
        {
            entry.SaveEntry();
        }
        // saves all the entries in the current journal.
    }

    public void LoadJournal( )
    {
        _journal.Clear();
    }

}