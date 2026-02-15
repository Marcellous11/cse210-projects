namespace EternalQest;

class SimpleGoal:Goals{

    public SimpleGoal(GoalData goalData):base(goalData){
        _goalData = goalData;
    }

    public override void AddGoal(string goal){
        _goalData._simpleGoals.Add(goal);
    }

    public override void RemoveGoal(int idx){
        _goalData._simpleGoals.RemoveAt(idx);
    }


}