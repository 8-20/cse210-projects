using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "y";
        while (playAgain == "y")
        {
            Random random = new Random();
        int magicNumber = random.Next(1, 501); // Range: 1 to 500
       // Console.WriteLine($"Random integer (1-500): {magicNumber}");

        Console.WriteLine("I'm thinking of a number between 1 and 500. Can you guess it? ");

            int highGuess = 500;
            int lowGuess = 1;
            int guesses = 1;

            do
            {
                if (guesses == 1)
                {
                    Console.Write("What is your first guess? ");
                }

                else
                {
                    Console.Write($"What guess number {guesses}? ");
                }
                int guess = int.Parse(Console.ReadLine());
                Console.WriteLine($"Your guess is: {guess}");


                if (guess == magicNumber)
                {
                    Console.WriteLine($"Congratulations! You guessed the magic number in {guesses} guesses!");
                    playAgain = "n";
                }
                else if (guess < magicNumber)
                {
                    lowGuess = guess;
                    Console.WriteLine($"The number is between {lowGuess} and {highGuess}. Guess again.");
                }
                else
                {
                    highGuess = guess;
                    Console.WriteLine($"The number is between {lowGuess} and {highGuess}. Guess again.");
                }
                guesses++;
            } while (guesses != magicNumber && playAgain == "y");

            Console.Write("Would you like to play again? (y/n) ");
            playAgain = Console.ReadLine();
                if (playAgain != "y")
                {
                    Console.WriteLine("Thanks for playing!");
                }
        }
    }
    
}