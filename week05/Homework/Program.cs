using System;
using Homework;

class Program
{
    static void Main(string[] args)
    {
        MathAssigment jerry = new MathAssigment("Jerry","Algebra","2.5","5(2x-4)");
        Console.WriteLine(jerry.GetHomeworkList());
        Console.WriteLine(jerry.GetSummary());

        WritingAssigment mat = new WritingAssigment("Matthew","Writing 2","Roman Empire");

        Console.WriteLine(mat.GetWritingInformation());
        Console.WriteLine(mat.GetSummary());
    }
}