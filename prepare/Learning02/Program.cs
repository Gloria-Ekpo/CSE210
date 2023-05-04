using System;

class Program
{
    static void Main(string[] args)
    {
    Job job1 = new Job();
    job1.JobTitle = "Software Engineer";
    job1.CompanyName = "Microsoft";
    job1.startYear = 2019;
    job1.endYear = 2022; 

    Job job2 = new Job();
    job2.JobTitle = "Web Developer";
    job2.CompanyName = "Apple";
    job2.startYear = 2017;
    job2.endYear = 2020;

    Resume myResume = new Resume();
    myResume.Name = "Gloria Ekpo";
    myResume.Jobs.Add(job1);
    myResume.Jobs.Add(job2);

    Console.WriteLine(myResume.Jobs[0].JobTitle);

    myResume.Display();
}

    }
