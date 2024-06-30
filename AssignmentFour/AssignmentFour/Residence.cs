//Name: Rupesh Shrestha(C0908441)
//Date: 2024 - 03 - 31

//Class representing a residence
public abstract class Residence
{
    private double _price;
    private double _squareFeet;
    private int _yearBuilt;
    private readonly double commissionRate = 2.8;
    private Address _address;

    //Properties for accessing residence details
    public double Price
    {
        get { return _price; }
        set { _price = value; }
    }

    public double SquareFeet
    {
        get { return _squareFeet; }
        set { _squareFeet = value; }
    }

    public int YearBuilt
    {
        get { return _yearBuilt; }
        set { _yearBuilt = value; }
    }

    public Address Address
    {
        get { return _address; }
        set { _address = value; }
    }

    //Default constructor initializes Residence with default values
    public Residence()
    {
        _price = 0;
        _squareFeet = 0;
        _yearBuilt = 0;
        _address = null;
    }

    public Residence(double price, double squareFeet, int yearBuilt, Address address)
    {
        this._price = price;
        this._squareFeet = squareFeet;
        this._yearBuilt = yearBuilt;
        this._address = address;
    }

    //CalculateCommission method to return commission amount
    public virtual double CalculateCommission()
    {
        return _price * commissionRate;
    }

    //Override ToString method to display residence info
    public override string ToString()
    {
        return $"Price: ${_price}\nYear Built: {YearBuilt}\nSquare Feet: {SquareFeet}\n{_address.ToString()}";
    }
}
