using System;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        Console.Write("Please enter the grade you received: ");
        string stringGrade = Console.ReadLine();
         int grade = int.Parse(stringGrade);
        {
            int plusMinus = grade % 10;

            if (grade >= 90)
            {
                letter = "A";

            }
            else if (grade >= 80)
            {
                letter = "B";
            }
            else if (grade >= 70)
            {
                letter = "C";
            }
            else if (grade >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }

            if (plusMinus >= 7 && letter != "F" && letter != "A")
            {
                Console.WriteLine($"Your grade is: {letter}+");
            }



            else if (plusMinus <= 3)
            {
                Console.WriteLine($"Your letter grade is: {letter}-");
            }

            else

            {
                Console.WriteLine($"Your letter grade is: {letter}");
            }

            if (grade >= 70)
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