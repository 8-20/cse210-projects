using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayMessage();

        string userName = PromptUserName();

        int favoriteNumber = PromptFavoriteNumber();

        int squaredNumber = SquareNumber(favoriteNumber);
 
        DisplayResult(userName, favoriteNumber, squaredNumber);
        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Program");
        }

        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptFavoriteNumber()
        {
            Console.Write("What is your favorite number? ");
            int favoriteNumber = int.Parse(Console.ReadLine());
            return favoriteNumber;
        }

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        static void DisplayResult(string userName, int favoriteNumber, int squaredNumber)
        {
            Console.WriteLine($"{userName}, the square of your favorite number, {favoriteNumber}, is {squaredNumber}.");
        }

    }
}



