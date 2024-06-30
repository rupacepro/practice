//Name: Rupesh Shrestha(C0908441)
//Date: 2024 - 03 - 31

namespace AssignmentThree
{
    //class representing an apartment, inheriting from Residence
    internal class Condo : Residence
    {
        private int _unit;
        private int _floor;
        private String _parking;

        //properties for accessig unit floorm and parking
        public int Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }

        public int Floor
        {
            get { return _floor; }
            set { _floor = value; }
        }

        public String Parking
        {
            get { return _parking; }
            set { _parking = value; }
        }

        //default constructor
        public Condo()
        {
            _unit = 0;
            _floor = 0;
            _parking = "No";
        }
        
        //parameterized constructor initializing an apartment with specified values
        public Condo(double price, double squareFeet, int yearBuilt, Address address, int unit, int floor, String parking)
            : base(price, squareFeet, yearBuilt, address)
        {
            _unit = unit;
            _floor = floor;
            _parking = parking;
        }

        //overriding ToString method
        public override string ToString()
        {
            return $"{base.ToString()}\nUnit: {_unit}\nFloor: {_floor}\nParking:{_parking}\nTotal Commission: ${CalculateCommission():F2}";
        }

        //Overriding CalculateCommission
        public override double CalculateCommission()
        {
            return base.Price * .04;
        }
    }
}
