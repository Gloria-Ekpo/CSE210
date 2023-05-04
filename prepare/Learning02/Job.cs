public class Job
{
    private string _jobTitle;
    private string _companyName;
    private double _salary;

    public string JobTitle
    {
        get { return _jobTitle; }
        set { _jobTitle = value; }
    }

    public string CompanyName
    {
        get { return _companyName; }
        set { _companyName = value; }
    }

    public double Salary
    {
        get { return _salary; }
        set { _salary = value; }
    }

    public void DisplayJobDetails()
    {
        Console.WriteLine("Job title: " + JobTitle);
        Console.WriteLine("Company name: " + CompanyName);
        Console.WriteLine("Salary: " + Salary);
    }
}
