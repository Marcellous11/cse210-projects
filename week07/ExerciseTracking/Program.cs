using System;
namespace ExerciseTracking;
class Program
{
    static void Main(string[] args)
    {
        Running run = new("01/21/2026",30,3);
        Swimming swim= new("01/21/2026",30,10);
        Cycling bike= new("01/21/2026",45,13);

        List<Activity> workouts = new (){run,swim,bike};

        workouts.ForEach((workout)=>{
            Console.WriteLine(workout.GetSummary());
        });
        
    }
}