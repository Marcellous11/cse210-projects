using System.Text;

namespace Mindfulness;

class BreathingActivity: Activity{

    public BreathingActivity(string name,string description,int duration):base(name,description,duration){
        _name = "Breathing Activity";
        _description = description;
        _duration = duration;
    }

    public void Run(){
        Console.Clear();
        Console.WriteLine(_description+"\n");
        string clearLine = "\b\b\b\b\b\b\b\b\b\b\b";
        DateTime currentTime = DateTime.Now; 
        DateTime endTime = currentTime.AddSeconds(_duration);
        int flipper = 0;
        
        while(currentTime < endTime){
            currentTime = DateTime.Now; 
            if( flipper % 2 == 0){
                Console.Write(clearLine);
                Console.Write("Breath in  ");
                StatusBar(5);
            }else{
                Console.Write(clearLine);
                Console.Write("Breath out ");
                StatusBar(5);
            }
            flipper++;
        }
        Console.WriteLine($"\nCongradulation!! You completed {_duration} seconds of the Breathing Activity");
        Thread.Sleep(5000);
    }

    private void StatusBar(int counter){
        StringBuilder line = new StringBuilder(new string('-',counter));
        for(int i = 0;i < line.Length ; i++){
            line[i] = '+';
            string cleanline = new string('\b',line.Length);
            Console.Write(line);
            Console.Write(cleanline);
            Thread.Sleep(1000);
        }
    }
}