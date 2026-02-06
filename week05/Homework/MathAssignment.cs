namespace Homework;

class MathAssigment: Assigment{
    private string _textBookSections;
    private string _problems;

    public MathAssigment(string studentName, string topic,string textBookSections,string problems):base(studentName,topic){
        _textBookSections = textBookSections;
        _problems = problems;
    }
    public string GetHomeworkList(){
        return new string($"Sections: {_textBookSections} Problems:{_problems}");
    }
}