public class Job
{
    public string _jobTitle = "";
    public string _jobCompany = "";
    public double _startYear;
    public double _endYear;

    public void Display()
    {   
        Console.WriteLine($"{_jobTitle} ({_jobCompany}) {_startYear}-{_endYear}" );
    }

} 