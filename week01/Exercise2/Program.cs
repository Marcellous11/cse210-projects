using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        int gradePercentage = -1;
        string letterGrade;
        bool passed = true;

      Console.Write("What was your grade percentage? ");    
          
        try{
            gradePercentage = int.Parse(Console.ReadLine());
        }catch{
            Console.WriteLine($"The value you enter was not a valid grade percentage");
        }

        if(gradePercentage < 0 || gradePercentage > 100)
        {
            Console.WriteLine("Grade must be inbetween 0 and 100.");
            return;
        }

        if(gradePercentage >= 90)
        {
            letterGrade = "A";
        }
        else if(gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if(gradePercentage >= 70)
        {
            letterGrade = "C";
        }
       else if( gradePercentage >= 60)
       {
            letterGrade = "D";
            passed = false;
       }
       else
       {
            letterGrade = "F";
            passed = false;
       }

        Console.Write($"\nYour letter grade is {letterGrade}.");
        if(passed){
            Console.Write($" Congradulations!! You passed!!");
        }
        
    }
}