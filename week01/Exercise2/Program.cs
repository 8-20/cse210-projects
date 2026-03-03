using System;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        Console.Write("Please enter the grade you received as a % (For Example: 88%)): ");
        string gradePerCent = Console.ReadLine();

        if (gradePerCent.Length > 0)
        {
            string grade = gradePerCent.Remove(gradePerCent.Length - 1);
            Console.WriteLine($"The grade you entered is: {grade}%.");

            char plusMinus = grade[grade.Length - 1];
            int numPlusMinus = plusMinus - '0';
            Console.WriteLine($"The last character of the grade is: {plusMinus}");

           int gradeNumber = int.Parse(grade);
            Console.WriteLine($"The grade number is: {gradeNumber}");

           if (gradeNumber >= 90)
            {
                //Console.WriteLine("Your letter grade is: A");
                letter = "A";

            }
            else if (gradeNumber >= 80)
            {
                //Console.WriteLine("Your letter grade is: B");
                letter = "B";
            }
            else if (gradeNumber >= 70)
            {
                //Console.WriteLine("Your letter grade is: C");
                letter = "C";
            }
            else if (gradeNumber >= 60)
            {
                //Console.WriteLine("Your letter grade is: D");
                letter = "D";
            }
            else
            {
                //Console.WriteLine("Your letter grade is: F");
                letter = "F";
            }

            if (numPlusMinus >= 7 && letter != "F" && letter != "A")
            {
                Console.WriteLine($"Your letter grade is: {letter}+");
            }



            else if (numPlusMinus <= 3)
            {
                Console.WriteLine($"Your letter grade is: {letter}-");
            }

            else

            {
                Console.WriteLine($"Your letter grade is: {letter}");
            }

            if (gradeNumber >= 70)
            {
                Console.WriteLine("Congratulations! You passed the class!");
            }
            else
            {
                Console.WriteLine("Sorry, you did not pass the class. Better luck next time!");
            }

        }


    

        

        

    }
}