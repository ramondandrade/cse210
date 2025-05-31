public class Address
{
    private string _street;
    private string _number;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string number, string city, string state, string country)
    {
        _street = street;
        _number = number;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetCountry()
    {
        return _country;
    }

    public string GetFullAddress()
    {
        return $"{_number} {_street}, {_city}, {_state}, {_country}";
    }
}
