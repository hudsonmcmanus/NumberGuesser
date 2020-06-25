using System;
using System.Xml.Schema;

// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            // Set App Vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Hudson McManus";

            // Change Text Color
            Console.ForegroundColor = ConsoleColor.Red;

            // Write App info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Change Color Back
            Console.ResetColor();

            // Ask user for name
            Console.WriteLine("What is your name?");
            string input = Console.ReadLine();

            // Greet user
            Console.WriteLine("Hello {0}, lets play a game...", input);

            // Set Number
            Random random = new Random();
            int randomNumber = random.Next(1, 11);

            // Ask user to guess
            Console.WriteLine("Guess what number im thinking of from 1-10 >:)");
            string userGuess = Console.ReadLine();
            int guess = Int32.Parse(userGuess);

            // Loop until user guesses correct number
            while (guess != randomNumber)
            {
                // Display error / wrong answer
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("I'm sorry, that number just isn't right, try again.");
                Console.ResetColor();

                // Overwrite existing guess
                userGuess = Console.ReadLine();
                guess = Int32.Parse(userGuess);
            }
            // Display success
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Congrats! You guessed the number I was thinking of {0}", randomNumber); Console.ResetColor();
        }
    }
}
