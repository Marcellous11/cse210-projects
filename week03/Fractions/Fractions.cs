namespace Franctions;

class Fractions{
    private int _top;
    private int _bottom;

    public Fractions(){

    }
    public Fractions(int wholeNumber){

    }
    public Fractions(int top, int bottom){
        _top = top;
        _bottom = bottom;
    }

    public void SetTop(int top){
        _top = top;
    }

    public int GetTop(){
        return _top;
    }
    public void SetBottom(int bottom){
        _bottom = bottom;
    }

    public int GetBottom(){
        return _bottom;
    }

    public string GetFractionString(){
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue(){
        return _top / (double)_bottom;
    }



}