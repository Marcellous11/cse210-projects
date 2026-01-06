using System;

class Program
{
    static void Main(string[] args)
    {
        bool userCorrect = false;
        int userGuess = -1;
        Random randomGen = new Random();

        int magicNumber = randomGen.Next(1,100);

        while(!userCorrect)
        {
            Console.Write("What is your guess for the magic number? ");
            try
            {
                userGuess =  int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Your guess must be a whole number");
            }

            if(userGuess == magicNumber)
            {
                Console.WriteLine("\nCongradulations!! You guessed it!!");
                userCorrect = true;
            }
            else if(userGuess > magicNumber)
            {
                Console.WriteLine("Lower...");
            }
            else
            {
                Console.WriteLine("Higher!");
            }
            
        }

    }
}