using System;
namespace Resumes;
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Sofware Engineer";
        job1._company = "Apple";
        job1._endYear = 2020;
        job1._startYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "AI Engineer";
        job2._company = "Microsoft";
        job2._endYear = 2022;
        job2._startYear = 2026;

        Resume resume1 = new Resume();

        resume1._name = "Marcellous Curtis";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();

    }
}