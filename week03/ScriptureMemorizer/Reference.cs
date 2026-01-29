using ScriputreMemorizer;

class Reference{
    public string _book;
    public int _chapter;
    public int _verse;
    public int _endVerse = -1;


    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book,int chapter, int verse,int endVerse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string DisplayText(){
        if(_endVerse > 0){
            return $"{_book} {_chapter}:{_verse} - {_endVerse}";
        }else{
            return $"{_book} {_chapter}:{_verse}";
        }
           
    }
}