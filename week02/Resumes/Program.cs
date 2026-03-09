using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Student";
        job1._company = "Brigham Young University";
        job1._startYear = 1965;
        job1._endYear = 1974;

        Job job2 = new Job();
        job2._jobTitle = "Assembly Line Supervisor";
        job2._company = "Avon Products, Inc .";
        job2._startYear = 1974;
        job2._endYear = 1985;

        Job job3 = new Job();
        job3._jobTitle = "Exchequer";
        job3._company = "Flintridge Acreage and Bridgework";
        job3._startYear = 1985;
        job3._endYear = 1987;

        Resume myResume = new Resume();
        myResume._name = "Paul Scherbel";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        myResume.Display();

    }
}