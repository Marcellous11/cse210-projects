// Adding more meaningful animations for the breathing (such as text that grows at a visual pass so the user can follow it.

using System;
namespace Mindfulness;
class Program
{
    static void Main(string[] args)
    {
        string userOption = "";
        int duration = 0;
        string menu = """
        Welcome to the Mindfulness Activity. Please Select an activity by typing a number below.

        1. Breathing Activity
        2. Refection Activity
        3. Listing Activity
        4. Quit
        """;
        string durationPrompt = "How long would you like the Activity to last? Enter a time in seconds";

        while(userOption != "4"){
            Console.Clear();
            Console.WriteLine(menu);
            userOption = Console.ReadLine();

            switch(userOption){
                
                case "1": 
                    Console.WriteLine("You've selected the Breathing Activity\n");
           
                    Console.WriteLine(durationPrompt);
                    try{

                        duration = int.Parse( Console.ReadLine().Trim());
                    }catch{
                        Console.Error.WriteLine("Non numeric value entered, try again.");
                    }
                    BreathingActivity breath = new BreathingActivity("Breathing Activity","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing",duration);
                    breath.Run();
                break;
                case "2":
                    Console.WriteLine("You've selected the Reflecting Activity\n");
           
                    Console.WriteLine(durationPrompt);
                    try{

                        duration = int.Parse( Console.ReadLine().Trim());
                    }catch{
                        Console.Error.WriteLine("Non numeric value entered, try again.");
                    }
                    ReflectingActivity relfect = new ReflectingActivity("Reflecting Activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",duration);
                    relfect.Run();

                break;
                case "3":
                    
                    Console.WriteLine("You've selected the Listing Activity\n");
           
                    Console.WriteLine(durationPrompt);
                    try{

                        duration = int.Parse( Console.ReadLine().Trim());
                    }catch{
                        Console.Error.WriteLine("Non numeric value entered, try again.");
                    }
                    ListingActivity listing = new ListingActivity("Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",duration);
                    listing.Run();
                break;
            }
        }
        Console.WriteLine("\nThank you for taking time to treat yourself");
        Thread.Sleep(3000);
    }
}