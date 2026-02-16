namespace ExerciseTracking;

class Swimming : Activity
{

    private double _laps;

    public Swimming(string date, double mins, int laps) : base(date, mins)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return Math.Round(_laps * 50 / 1000 * 0.62, 2);
    }

    public override string GetSummary()
    {
        return $"{GetDate()} ({_mins} min)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }


}