namespace ExerciseTracking;

class Running:Activity{

    private double _miles;

    public Running(string date,double mins,double miles):base(date,mins){
        _miles = miles;
    }

    public override double GetDistance(){
        return _miles;
    }

    public override double GetSpeed(){
        return (_miles/_mins) * 60;
    }
    public override double GetPace(){
        return _mins/ _miles;
    }

    public override string GetSummary(){
        return $"{GetDate()} ({_mins} min)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }

    
}