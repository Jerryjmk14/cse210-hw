public class Address
{
    //Attributes
    private string _streeAddresst; 
    private string _city;
    private string _stateOrProvince;
    private string _country;

    //constructor
    public Address(string address, string city, string state, string country)
    {
        _city = city;
        _streeAddresst = address;
        _stateOrProvince = state;
        _country = country;
    }

    //methods
    public bool IsInUSAOrNot()
    {
        if (_country.ToLower() == "usa")
        {
            return true;
        } else
        {
            return false;
        }
    }

    public string DisplayAddress()
    {
        return $"{_streeAddresst}, {_city}, {_stateOrProvince}, {_country}";
    }
}