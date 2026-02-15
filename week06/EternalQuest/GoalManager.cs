namespace EternalQest;
class GoalManager{

    GoalData _goalData;
    SimpleGoal simpleGoal;
    EternalGoals eternalGoals;
    ChecklistGoals checklistGoals;
    
    public GoalManager(GoalData goalData){
        _goalData = goalData;
        simpleGoal = new SimpleGoal(_goalData);
        eternalGoals = new EternalGoals(_goalData);
        checklistGoals = new ChecklistGoals(_goalData);
    }
    public void SimpleGoalDisplay(){
        string userOption = null;
        string statusMessage = null;


        while(true){
            string simpeGoals = "";
            for(int i = 0; i < _goalData._simpleGoals.Count;i++){
                simpeGoals += $"{i + 1}. {_goalData._simpleGoals[i]}\n";
            }
            string menu = $"""
            **** SIMPLE GOAL (100 points each!) ****
            {simpeGoals}

            Select number to complete goal, type "b" to save and exit, or write out new goal: 
            {statusMessage ?? null }
            """;
            Console.Clear();
            Console.WriteLine(menu);
            userOption = Console.ReadLine().ToLower().Trim();

            if (userOption == "b"){
                break;
            } 

            if(Int32.TryParse(userOption,out int value)){
                if(value <= _goalData._simpleGoals.Count){
                    Console.WriteLine("a) Completed b) Remove from list");
                    string goalUpdateOption = Console.ReadLine().ToLower().Trim();
                    if(goalUpdateOption == "a"){
                        simpleGoal.UpdateScore(100); 
                        simpleGoal.RemoveGoal(value - 1);
                        statusMessage = " - 50 points added! - ";
                    }else if(goalUpdateOption == "b"){
                        simpleGoal.RemoveGoal(value - 1);
                        statusMessage = " - Goal as been removed, no points added - ";
                    }else{
                    }
                }else{
                    statusMessage = " - Value out of index, try again - ";    
                }
                
            }else if(!string.IsNullOrEmpty(userOption)){
                 simpleGoal.AddGoal(userOption);
                  statusMessage = null;
            }else{
                statusMessage =" - Please add a value - ";
            }
           

        }
                
    }
    public void EternalGoalDisplay(){
        string statusMessage = null;


        while(true){
            string eteranlGoals = "";
            for(int i = 0; i < _goalData._eternalGoals.Count;i++){
                eteranlGoals += $"{i + 1}. {_goalData._eternalGoals[i]}\n";
            }
            string menu = $"""
            **** ETERNAL GOAL (50 points each!) ****
            {eteranlGoals}

            Select number to complete goal, type "b" to save and exit, or write out new goal: 
            {statusMessage ?? null }
            """;
            Console.Clear();
            Console.WriteLine(menu);
            string userOption = Console.ReadLine().ToLower().Trim();

            if (userOption == "b"){
                break;
            } 

            if(Int32.TryParse(userOption,out int value)){
                if(value <= _goalData._eternalGoals.Count){
                    Console.WriteLine("a) Completed b) Remove from list");
                    string goalUpdateOption = Console.ReadLine().ToLower().Trim();
                    if(goalUpdateOption == "a"){
                        eternalGoals.UpdateScore(50); 
                        statusMessage = " - 50 points added! - ";
                    }else if(goalUpdateOption == "b"){
                        eternalGoals.RemoveGoal(value - 1);
                        statusMessage = " - Goal as been removed, no points added - ";
                    }else{
                        statusMessage = " - Not a valid option - ";
                    }
                }else{
                    statusMessage = " - Value out of index, try again - ";    
                }
                
            }else if(!string.IsNullOrEmpty(userOption)){
                 eternalGoals.AddGoal(userOption);
                  statusMessage = null;
            }else{
                statusMessage =" - Please add a value - ";
            }
           

        }
                
    }

        public void ChecklistGoalDisplay(){
        string userOption = null;
        string statusMessage = null;


        while(true){
            string simpeGoals = "";
            
            for(int i = 0; i < _goalData._checklistGoals.Count;i++){
                string currentGoal = _goalData._checklistGoals[i];
                if(checklistGoals.IsCheck(currentGoal)){
                    simpeGoals += $"[X]{i + 1}. {currentGoal}\n";
                }else{
                    simpeGoals += $"[ ]{i + 1}. {currentGoal}\n";
                }
            
            }
            
            string menu = $"""
            **** CHECK LIST GOALS (10 points each! - 100 bonus when completed!!) ****
            {simpeGoals}

            Select number to complete goal, type "b" to save and exit, or write out new goal: 
            {statusMessage ?? null }
            """;
            Console.Clear();
            Console.WriteLine(menu);
            userOption = Console.ReadLine().ToLower().Trim();

            if (userOption == "b"){
                break;
            } 

            if(Int32.TryParse(userOption,out int value)){
                if(value <= _goalData._checklistGoals.Count){
                    Console.WriteLine("a) Completed b) Remove from list");
                    string goalUpdateOption = Console.ReadLine().ToLower().Trim();
                    if(goalUpdateOption == "a"){
                        checklistGoals.UpdateScore(10); 
                        checklistGoals.AddToChecked(value -1); 
                        statusMessage = " - 10 points added! - ";
                    }else if(goalUpdateOption == "b"){
                        checklistGoals.RemoveGoal(value - 1);
                        statusMessage = " - Goal as been removed, no points added - ";
                    }else{
                    }
                    
                    if(_goalData._checklistGoals.SequenceEqual(_goalData._completedChecklistGoals) &&_goalData._checklistGoals.Count > 0){
                        checklistGoals.ClearChecked();
                        checklistGoals.UpdateScore(100);
                        checklistGoals.UpdateScore(10);
                        statusMessage = " - 100 points added! - ";
                    }

                }else{
                    statusMessage = " - Value out of index, try again - ";    
                }
                
            }else if(!string.IsNullOrEmpty(userOption)){
                checklistGoals.AddGoal(userOption);
                statusMessage = null;
            }else{
                statusMessage =" - Please add a value - ";
            }
           

        }
                
    }

}
    
