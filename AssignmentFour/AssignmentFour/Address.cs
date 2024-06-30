//Name: Rupesh Shrestha(C0908441)
//Date: 2024 - 03 - 31

//class representing an address
public class Address
{
    private string _street;
    private string _municipality;
    private string _region;
    private string _postalCode;

    //Properties for accessing address details
    public string Street
    {
        get { return _street; }
        set { _street = value; }
    }

    public string Municipality
    {
        get { return _municipality; }
        set { _municipality = value; }
    }

    public string Region
    {
        get { return _region; }
        set { _region = value; }
    }

    public string PostalCode
    {
        get { return _postalCode; }
        set { _postalCode = value; }
    }

    //Default constructor initializes address with default values
    public Address()
    {
        this._street = "6 Scarborough Golf Club Rd";
        this._municipality = "Toronto";
        this._region = "Ontario";
        this._postalCode = "M1M3C5";
    }

    //Constructor with parameters
    public Address(string street, string municipality, string region, string postcode)
    {
        this._street = street;
        this._municipality = municipality;
        this._region = region;
        this._postalCode = postcode;
    }

    //Override ToString method to display address info
    public override string ToString()
    {
        return $"Street: {_street}\nCity: {_municipality}\nState: {_region}\nzipCode: {_postalCode}";
    }
}
