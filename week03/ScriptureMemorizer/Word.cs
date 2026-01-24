namespace ScriputreMemorizer;

class Word{
    private string _text;
    private bool _isHidden = false;

    public Word(string word){
        _text = word;
    }
    public void Hide(){
        _isHidden = true;
    }
    public void Show(){
        _isHidden = false;
    }
    public bool IsHidden(){
        return _isHidden;
    }
    public string GetDisplayTetxt(){

        if(_isHidden){
            return new string('_' ,_text.Length);
        }else{
            return _text;
        }
    }
}