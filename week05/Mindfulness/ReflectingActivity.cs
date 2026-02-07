namespace Mindfulness;
using System.Text;

class ReflectingActivity: Activity{
    private List<string> _prompts = new List<string>{"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.","Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."};
    private List<string> _questions  = new List<string>{"Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?","How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"};
    private List<int> randomPromptIndex = new List<int>(); 
    private List<int> randomQuestionsIndex = new List<int>(); 

    public ReflectingActivity(string name, string description,int duration):base(name,description,duration){
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void Run(){
        Console.Clear();
        Console.WriteLine(_description+"\n");
        Thread.Sleep(5000);
        Console.WriteLine(GetRandomPrompt());
        StatusBar();
        Console.WriteLine(GetRandomQuestion());
        StatusBar();
        StatusBar();
        Console.WriteLine("\nCongradulation! You have completed Reflecting Activity!");
        Thread.Sleep(5000);
    }
    public string GetRandomQuestion(){
        Random rand = new Random();
        int randomNum = rand.Next(0,_questions.Count);
        randomQuestionsIndex.Add(randomNum);
        return _questions[randomNum];
    }
    public string GetRandomPrompt(){
        Random rand = new Random();
        int randomNum = rand.Next(0,_prompts.Count);
        return _prompts[randomNum];
    }

    private void StatusBar(){
        List<string> spinnerList = new List<string>{"—","\\","|","/"};
        DateTime currentTime = DateTime.Now; 
        DateTime endTime = currentTime.AddSeconds(_duration);
        while(currentTime < endTime){
            currentTime = DateTime.Now; 
            for(int i = 0;i < spinnerList.Count - 1 ; i++){
            Console.Write(spinnerList[i]);
            Thread.Sleep(100);
            Console.Write("\b");
            }
        }
    }
}