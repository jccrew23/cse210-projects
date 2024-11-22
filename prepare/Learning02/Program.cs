using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._company = "Dell";
        job1._jobTitle = "Developer";
        job1._startYear = 2019;
        job1._endYear = 2023;


        Job job2 = new Job();

        job2._company = "Apple";
        job2._jobTitle = "Intern";
        job2._startYear = 2015;
        job2._endYear = 2019;


        Resume resumeFull = new Resume();

        resumeFull._name = "Jalie Curtis";

        resumeFull._jobs.Add(job1);
        resumeFull._jobs.Add(job2);

        resumeFull.DisplayResume();
    }

}