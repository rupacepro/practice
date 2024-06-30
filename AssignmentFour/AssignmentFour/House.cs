//Name: Rupesh Shrestha(C0908441)
//Date: 2024 - 03 - 31

namespace AssignmentThree
{
    //class representing a house, inheriting from Residence class
    internal class House : Residence
    {
        private String _garage;
        private String _type;
        private String _condition;

        //properties for accessing garage, typem and condition
        public String Garage
        {
            get { return _garage; }
            set { _garage = value; }
        }

        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public String Condition
        {
            get { return _condition; }
            set { _condition = value; }
        }

        //default constructor
        public House() { }

        //parameterized constructor
        public House(double price, double squareFeet, int yearBuilt, Address address, String garage, String type, String condition)
            : base(price, squareFeet, yearBuilt, address)
        {
            _garage = garage;
            _type = type;   
            _condition = condition;
        }

        //overriding ToString method to display house info
        public override string ToString()
        {
            return $"{base.ToString()}\nGarage: {_garage}\nType: {_type}\nCondition: {_condition}\nTotal Commission: ${CalculateCommission():F2}";
        }
        
        //overriding CalculateCommission method
        public override double CalculateCommission()
        {
            return base.Price * .035;
        }
    }
}
