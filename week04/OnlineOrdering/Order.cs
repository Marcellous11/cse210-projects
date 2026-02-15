namespace OnlineOrdering;
class Order{

    private Customer _customer;
    private List<Product> _products;
    private int SHIPPING_COST = 0;

    public Order(Customer customer, List<Product> products){
        _customer = customer;

        Random rand = new Random();
        products.ForEach(product => product.SetProductID(rand.Next(1000,9999)));

        _products = products;
    }

    public decimal GetTotalCost(){
        if(_customer.IsInUSA()){
            SHIPPING_COST = 5;
        }{
            SHIPPING_COST = 35;
        }
        return decimal.Round(_products.Sum(product=>product.GetPrice()),2) + SHIPPING_COST;
    }

    public string GetPackingLabel(){
        string label = "\nPacking Label:\n";
        _products.ForEach(product => {
            label +=$"\tProduct: {product.GetName()}, Product ID: {product.GetProductID()}\n";
            });
        return label;
    }
    public string GetShippingLabel(){
        return $"Name: {_customer.GetName()}\nAddress: {_customer.GetAddress()}";
            
    }
        
    }