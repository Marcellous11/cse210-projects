namespace Homework;

class Assigment{

    protected string _studentName;
    private string _topic;
    public Assigment(string studentName,string topic){
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary(){
        return $"Name: {_studentName}\nTopic: {_topic}";
    }

}