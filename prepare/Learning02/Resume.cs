using System;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public List<Job> Jobs
    {
        get { return _jobs; }
        set { _jobs = value; }
    }
    public void Display()
    {
        Console.WriteLine($"Resume for {_name}:");
        Console.WriteLine();

        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
            Console.WriteLine();
        }
    }
}