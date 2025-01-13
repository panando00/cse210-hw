using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int magicNumber = random.Next(1, 101);

        int guess;
        bool isCorrect = false;
        
        while (!isCorrect)
        {
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out guess))
            {
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
                    isCorrect = true;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}