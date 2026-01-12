using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Senior Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2030;
        job1._endYear = 2040;

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "BYUI";
        job2._startYear = 2026;
        job2._endYear = 2030;

        Resume resume1 = new Resume();
        resume1._name = "Brady Burgener";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
}