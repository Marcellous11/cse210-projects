namespace ExerciseTracking;

class Cycling : Activity
{

    private double _miles;

    public Cycling(string date, double mins, int miles) : base(date, mins)
    {
        _miles = miles;
    }

    public override double GetDistance()
    {
        return _miles ;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} ({_mins} min)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }


}