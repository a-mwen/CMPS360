using System;

namespace dotnetHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the House of EMOTION!!!!!!!!");

            // Generate Random Number
            Random random = new Random();
            int targetNumber = random.Next(1, 10);

            int maxAttempts = 3; // Added: Set a maximum number of attempts
            int attempts = 0;
            bool hasGuessedCorrectly = false;

            Console.Write($"Try to guess the number between 1 and 10 (You have {maxAttempts} attempts)");

            while (!hasGuessedCorrectly && attempts < maxAttempts)
            {
                Console.WriteLine("Input your guess: ");
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int userGuess))
                {
                    attempts++;
                    if (userGuess == targetNumber)
                    {
                        hasGuessedCorrectly = true;
                        Console.Write($"Well Done, you guessed right in {attempts} attempts");
                    }
                    else
                    {
                        string hint = (userGuess < targetNumber) ? "Too low, Try again!" : "Too high.. Try again!";
                        Console.WriteLine(hint);
                        Console.WriteLine($"Attempts remaining: {maxAttempts - attempts}");
                    }
                }
                else
                {
                    Console.WriteLine("That's not a valid input, please enter a number!");
                }
            }

            // Game outcome
            if (!hasGuessedCorrectly)
            {
                Console.WriteLine($"Sorry, you've reached the maximum attempts. The correct number was {targetNumber}");
            }

            // Ask to play again
            Console.Write("Do you want to play again? (yes/no): ");
            string playAgainInput = Console.ReadLine();

            if (playAgainInput.ToLower() == "yes")
            {
                // Reset variables and play again
                targetNumber = random.Next(1, 10);
                attempts = 0;
                hasGuessedCorrectly = false;
                Console.Clear(); // Added: Clear console for a fresh start
                Main(args); // Added: Recursive call to Main for a new game
            }
            else
            {
                Console.WriteLine("Thank you for playing House of EMOTION!!!!!!!!!");
            }
        }
    }
}
