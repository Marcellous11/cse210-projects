namespace EternalQest;

class ChecklistGoals:Goals{


    public ChecklistGoals(GoalData goalData):base(goalData){
        _goalData = goalData;
    }

    public override void AddGoal(string goal){
        _goalData._checklistGoals.Add(goal);
    }

    public override void RemoveGoal(int idx){
        _goalData._checklistGoals.RemoveAt(idx);
        _goalData._completedChecklistGoals.Remove(_goalData._checklistGoals[idx]);
    }

    public bool IsCheck(string goal){
        return _goalData._completedChecklistGoals.Contains(goal);
    }

    public void AddToChecked(int idx){
        _goalData._completedChecklistGoals.Add(_goalData._checklistGoals[idx]);
    }

    public void ClearChecked(){
        _goalData._completedChecklistGoals.Clear();
    }

}