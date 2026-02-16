using System.Globalization;

namespace ExerciseTracking;

abstract class Activity{
    protected string _date {get;set;}
    protected double _mins;


    public Activity(string date,double mins){
        _date = date;
        _mins = mins;
    }   

    public abstract double GetDistance();

     public double GetSpeed()
    {
        return Math.Round(GetDistance() / _mins * 60, 2);
    }
    public double GetPace()
    {
        return Math.Round(_mins / GetDistance(), 2);
    }

    public abstract string GetSummary();

    public string GetDate(){
        string format = "dd MMM yyyy";
        string inputformat = "MM/dd/yyyy";
        
         if(   DateTime.TryParseExact(_date,inputformat,CultureInfo.InvariantCulture,DateTimeStyles.None,out DateTime dt)){
            _date =  dt.ToString(format);
         }else{
             Console.WriteLine("Invalid Format");
         }
         return _date;
    }
}