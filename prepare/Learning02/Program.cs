using System;
using System.Security.Cryptography.X509Certificates;



class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");
        
        Job job1 = new Job();
        job1._jobCompany = "Cisco";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 1999;
        job1._endYear = 2009;
        
        Job job2 = new Job();
        job2._jobCompany = "Microsoft";
        job2._jobTitle = "Senior Software Engineer";
        job2._startYear = 2009;
        job2._endYear = 2011;
        
        Resume resume1 = new Resume();
        resume1._personName = "Jon";

        resume1._resumeJobs.Add(job1);
        resume1._resumeJobs.Add(job2);

        resume1.Display(resume1._resumeJobs);

    }
}