using System;

class Program
{
    static void Main()
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "BYU";
        job1._endYear = 2025;
        job1._startYear = 2020;
        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Accountant";
        job2._company = "HR_Block";
        job2._endYear = 2022;
        job2._startYear = 2000;
        job2.Display();

        Resume resume = new Resume();
        resume._name = "Charlie Baker";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
}

