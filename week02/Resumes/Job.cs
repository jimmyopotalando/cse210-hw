// Job.cs
using System;

public class Job
{
    // Member variables (fields)
    private string _jobTitle;
    private string _company;
    private int _startYear;
    private int _endYear;

    // Constructor
    public Job(string jobTitle, string company, int startYear, int endYear)
    {
        _jobTitle = jobTitle;
        _company = company;
        _startYear = startYear;
        _endYear = endYear;
    }

    // Method to display job details
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
