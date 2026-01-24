namespace ScriputreMemorizer;

class Scripture{
    private Reference _reference;
    private List<Word> _words;
    private HashSet<int> hiddenIndx  = new HashSet<int>();

    public Scripture(Reference reference, string text){
        _reference = reference;
        _words = text.Split(" ").Select(w => new Word(w)).ToList<Word>();

    }

    public bool allDone(){
        return _words.All(word => word.IsHidden());
    }

    public void Reset(){
        _words.ForEach(w => w.Show());
        hiddenIndx = new HashSet<int>();
    }
    public void HideRandomWord(){
        Random rand = new Random();
        
        for(int i=0;i < 3; i++){
            hiddenIndx.Add(rand.Next(0,_words.Count ));
        }   
        foreach(int i in hiddenIndx){
            _words[i].Hide();
        }

    }
    public string GetDisplayText(){
        Console.Clear();    
        string verse =  string.Join(" ",_words.Select(word => word.GetDisplayTetxt() ));
        string reference = _reference.DisplayText();
        return $"{reference} {verse}";
    }
 }