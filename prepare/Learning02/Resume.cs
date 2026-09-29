public class Resume
{
    public string _personName = "";
    public List<Job> _resumeJobs = new List<Job>();


    public void Display(List<Job> _resumeJobs)
    {
        Console.WriteLine($"Names: {_personName}");
        Console.WriteLine($"Jobs:");
        foreach (Job item in _resumeJobs)
        {
            item.Display();
        }
    }
}