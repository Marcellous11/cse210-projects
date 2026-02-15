using System;
using System.Text.Json;
namespace EternalQest;
class Program
{
    static void Main(string[] args)
    {   
  
        GoalData userData = GetUserScore();
        GoalManager gm = new GoalManager(userData);
        string userOption = "";
        
        while(userOption != "d"){
            string menu  = $"""
            **** GOAL TRACKER ****
            Current User Score: {userData.score}

            A. Simple goal
            B. External goals
            C. Checklist goals 
            D. Quit program

            Select a goal (using letter): 
            """;
            
            Console.Clear();
            Console.Write(menu);
            userOption = Console.ReadLine().ToLower().Trim();

            switch(userOption){
                case "a":
                    gm.SimpleGoalDisplay();
                    UpdateUserScore(userData);
                    break;
                case "b":
                    gm.EternalGoalDisplay();
                    UpdateUserScore(userData);
                    break;
                case "c":
                     gm.ChecklistGoalDisplay();
                    UpdateUserScore(userData);
                    break;
            }
            
            Console.WriteLine("GoodBye!");
        }

    }

    static GoalData GetUserScore(){
        string userdataString = File.ReadAllText("userdata.json");
        GoalData userData = new GoalData();
        if(!string.IsNullOrEmpty(userdataString) ){
            userData = JsonSerializer.Deserialize<GoalData>(userdataString);
        }
        
        return userData;
    }
    static void  UpdateUserScore(GoalData data){
        string userData = JsonSerializer.Serialize<GoalData>(data);
        File.WriteAllText("userdata.json",userData);
    }
}