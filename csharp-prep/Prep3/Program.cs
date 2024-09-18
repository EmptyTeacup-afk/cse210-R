using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        string playAgain = "y";
        
        while (playAgain == "y")
        {
        int magicNumber = randomGenerator.Next(1, 101);
        int guessNumber = -1;
        int count = 0;
            
            while (magicNumber != guessNumber)
            {
                Console.WriteLine("What is your guess?");
                guessNumber = int.Parse(Console.ReadLine());

                if (magicNumber > guessNumber)
                {
                    Console.WriteLine("Guess higher");
                    count += 1;
                }
                else if (magicNumber < guessNumber)
                {
                    Console.WriteLine("Guess lower");
                    count += 1;
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {count} guesses.");
                }
            }  
        
            Console.WriteLine("Would you like to play again (y/n)?");
            playAgain = Console.ReadLine();

        }
    }
}