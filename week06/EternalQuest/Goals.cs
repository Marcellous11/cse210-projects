namespace EternalQest;

abstract class Goals{

    protected GoalData _goalData; 

    public Goals(GoalData goalData){
        _goalData = goalData;
    }

    public abstract void AddGoal(string goal);

    public abstract void RemoveGoal(int idx);

    public void UpdateScore(int points){
        _goalData.score += points;
    }


    

}