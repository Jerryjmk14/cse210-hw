public class Customer
{
    //Attributes
    private string _customerName;
    private Address _customerAddress;
    // Consructors
    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _customerAddress = address;
    }

    //methods
    public string DisplayCustomer()
    {
        
        return $"Customer Name: {_customerName} Address: {_customerAddress.DisplayAddress()}";
        
    }
    public void IsInUSA()
    {

    }

}