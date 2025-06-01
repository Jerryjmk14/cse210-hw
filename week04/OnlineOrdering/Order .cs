public class Order
{
    //member variables
   private List<Product> _customerOrderList = new List<Product>();
   private int _totalPrice;
   private int _shippingCost;
   private bool _isCustomerUSA;
   private string _packingLabel;
   private string _shippingLabel;

   //methods
   public void AddProduct(Product product, Customer customer)
   {
    _customerOrderList.Add(product);
    // _customerOrderList.Add(customer);

   }

    public string DisplayPackingLabel(string productName, int productID )
    {
        _packingLabel = $"Product Name: {productName} ID: {productID}";
        return _packingLabel;
    } 
    public string DisplayShippingLabel(Customer customerName, Address address)
    {
        _shippingLabel = $"Customer Name: {customerName} Address: {address}";
        return _shippingLabel;
    }
    public int CalculateTotalCost(int totalProductCost)
    {
        if (_isCustomerUSA == true)
        {
            _shippingCost = 5;
            _totalPrice = totalProductCost + _shippingCost;
            return _totalPrice;
        }
        else
        {
            _shippingCost = 35;
            _totalPrice = totalProductCost + _shippingCost;
            return _totalPrice;
        }
        
    } 
}