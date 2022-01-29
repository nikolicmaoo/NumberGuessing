using System;

namespace NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomNumber = new Random().Next(1, 100);

             static int GetGuess()
            {
                Console.WriteLine("Please enter your guess.");
                int guess = 0;
                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("You did not enter a valid guess.");
                    guess = GetGuess();
                }
                return guess;
            }
            int allowedTries = 5;
            int numberOfTries = 0;

            while (true)
            {
                int guess = GetGuess();
                numberOfTries++;
                if (guess == randomNumber)
                {
                    Console.WriteLine("Your guess was correct!");
                    break;
                }
                if (guess > randomNumber)
                {
                    Console.WriteLine("Your guess was too high");
                }
                if (guess < randomNumber)
                {
                    Console.WriteLine("Your guess was too low");
                }
                if (numberOfTries == allowedTries)
                {
                    Console.WriteLine($"The number was: {randomNumber}");
                    break;
                }
                Console.Write($"You have {allowedTries - numberOfTries} tries left. Enter another number: ");
            }
        }
    }
}
