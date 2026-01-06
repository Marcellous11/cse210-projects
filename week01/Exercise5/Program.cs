using System;

class Program
{
    static void Main(string[] args)
    {
        string userName;
        int userNumber;
        int userNumberSquared;

        DisplayWelcome();
        userName = PromptUserName();
        userNumber = PromptUserNumber();
        userNumberSquared = SquareNumber(userNumber);
        DisplayResult(userName,userNumberSquared);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to my program!!!!");
    }

    static string PromptUserName()
    {   
        Console.Write("Please enter your name: ");
        return Console.ReadLine(); 
    }

    static int PromptUserNumber()
    {
        int favNumber;
        Console.Write("Please enter your favorite number: ");
        while(true)
        {
            try
            {
                favNumber = int.Parse(Console.ReadLine());
                return favNumber; 
            }
            catch
            {
                Console.WriteLine("Please enter a whole number for favorite number.");
            }
        }
    }
    
    static int SquareNumber(int userNumber)
    {
        return userNumber * userNumber;
    }

    static void DisplayResult(string userName, int number)
    {   
        Console.WriteLine($"{userName}, the squre of your number is {number}");
    }
}