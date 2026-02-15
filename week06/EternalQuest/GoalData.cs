namespace EternalQest;
class GoalData {
    public int score {get;set;}
    public List<string> _simpleGoals {get;set;} = new List<string>();
    public List<string> _eternalGoals {get;set;} = new List<string>();
    public List<string> _checklistGoals {get;set;} = new List<string>();
    public List<string> _completedChecklistGoals {get;set;} = new List<string>();
    
}