using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;

        while (playAgain)
        {
            
            Console.Write("Enter the magic number (1-100): ");
            int magicNumber = int.Parse(Console.ReadLine());

            
            int guess;
            int numberOfGuesses = 0;

            
            do
            {
                
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                
                numberOfGuesses++;

                
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {numberOfGuesses} guesses.");
                }
            }
            while (guess != magicNumber); 

            
            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();
            if (response != "yes")
            {
                playAgain = false;
            }
        }

        
        Console.WriteLine("Thanks for playing! Goodbye!");
    }
}
