namespace OnlineOrdering;
class Product{
    private string _name;
    private int _productId;

    private decimal _price ;
    private int _quantity;

    public Product(string name,decimal price,int quantity){
        _name = name;
        _price = price;
        _quantity = quantity;
        
    }
    public double GetPrice(){
        return (double)(_price * _quantity);
    }
    public int GetProductID(){
        return _productId;
    }
    public void SetProductID(int id){
        _productId = id;
    }
    public string GetName(){
        return _name;
    }
}
