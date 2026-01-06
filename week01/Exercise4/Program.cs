using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> userNumbers = new List<int>();
        int newNum = -1;
        
        Console.WriteLine("Enter a list of numbers, type 0 when done.");
        while(newNum != 0)
        {
            Console.Write("Enter Number: ");
            try
            {
                newNum = int.Parse(Console.ReadLine());
            }
           catch
           {
                Console.WriteLine("Value number be a whole number");
           }

           if(newNum != 0)
           {
                userNumbers.Add(newNum);
           }
        }

        Console.WriteLine($"Sum: {userNumbers.Sum()}");
        Console.WriteLine($"Average: {userNumbers.Average()}");
        Console.WriteLine($"Largest Number: {userNumbers.Max()}");
    }
}