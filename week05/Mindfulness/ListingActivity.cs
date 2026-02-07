namespace Mindfulness;

class ListingActivity: Activity{
    private List<string> _prompts = new List<string>{"Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};
    private List<int> randomPromptIndex = new List<int>(); 
    private List<string> _userAnswers = new List<string>();

    public ListingActivity(string name,string description,int duration):base(name,description,duration){
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void Run(){
        
        Console.Clear();
        Console.WriteLine(_description+"\n");
        UserInteraction(_duration);

        Console.WriteLine($"\nCongradulation! You have completed Reflecting Activity and had {_userAnswers.Count} responses!");
        Thread.Sleep(5000);
    }

    private string GetRandomPrompt(){
        Random rand = new Random();
        int randomNum = rand.Next(0,_prompts.Count);
        return _prompts[randomNum];
    }

    private void UserInteraction(int duration){
        string userResponse;
        DateTime currentTime = DateTime.Now; 
        DateTime endTime = currentTime.AddSeconds(_duration);
        Console.WriteLine(GetRandomPrompt());
        while(currentTime < endTime){
            currentTime = DateTime.Now; 
            userResponse =  Console.ReadLine();
            _userAnswers.Add(userResponse);
        }

    }
}


