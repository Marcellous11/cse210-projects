namespace EternalQest;

class EternalGoals:Goals{

    public EternalGoals(GoalData goalData):base(goalData){
        _goalData = goalData;
    }

    public override void AddGoal(string goal){
        _goalData._eternalGoals.Add(goal);
    }

    public override void RemoveGoal(int idx){
        _goalData._eternalGoals.RemoveAt(idx);
    }
}