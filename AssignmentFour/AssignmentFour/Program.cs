//Name: Rupesh Shrestha(C0908441)
//Date: 2024 - 03 - 31

//Main class or entry point
using AssignmentThree;
class Program
{
    //main method
    public static void Main(string[] args)
    {
        //List to store houses and apartments
        var houses = new List<House>();
        var apartments = new List<Condo>();

        int choice;
        //Main loop to handle user input and display menu
        do
        {
            choice = Menu();
            switch (choice)
            {
                //if choice is 1 add a house and display info
                case 1:
                    House house = GetHouseObject();
                    houses.Add(house);
                    Console.WriteLine("------------------------------\n");
                    Console.WriteLine("A house is added to the list!!");
                    Console.WriteLine($"House Info: \n\n{house.ToString()}");
                    Console.WriteLine("----------------------------------\n");
                    break;
                //if choice is 2 add an apartment and display info
                case 2:
                    Condo apartment = GetApartmentObject();
                    apartments.Add(apartment);
                    Console.WriteLine("------------------------------\n");
                    Console.WriteLine("An apartment is added to the list!!");
                    Console.WriteLine($"House Info: \n\n{apartment.ToString()}");
                    Console.WriteLine("----------------------------------\n");
                    break;
                //if choice is 3 exit the program
                case 3:
                    Console.WriteLine("Thank You!!");
                    break;
            }
        } while (choice == 1 || choice == 2); //continue looping if choice is 1 or 2

    }

    //Method to get details of a house from the user
    static House GetHouseObject()
    {
        //variable to store house details
        String garage, type, condition;
        var address = GetValidAddress();
        double price = ReadDouble("Enter price: ");
        double squareFeet = ReadDouble("Enter square feet: ");
        int yearBuilt = ReadYearBuilt("Enter year built: ");
        //loops to insure valid input for house
        do
        {
            Console.WriteLine("Does it have garage ? yes or no?: ");
            garage = Console.ReadLine().ToLower();
            if (garage != "yes" && garage != "no")
                Console.WriteLine("Invalid input!! Enter 'yes' or 'no'.");
        } while (garage != "yes" && garage != "no");

        do
        {
            Console.WriteLine("Is this a detached house? type \"detached\" or \"attached\": ");

            type = Console.ReadLine().ToLower();
            if (type != "detached" && type != "attached")
                Console.WriteLine("Invalid input!! Enter \"detached\" or \"attached\".");
        } while (type != "detached" && type != "attached");

        do
        {
            Console.WriteLine("Is the houe for sale or for rent? type \"for sale\" or \"for rent\"?: ");
            condition = Console.ReadLine().ToLower();
            if (condition != "for sale" && condition != "for rent")
                Console.WriteLine("Invalid input!! Enter 'for sale' or 'for rent'.");
        } while (condition != "for sale" && condition != "for rent");

        //return address new House object with the user entered details
        return new House(price, squareFeet, yearBuilt, address, garage, type, condition);
    }

    //method to get details of an apartment from the user
    public static Condo GetApartmentObject()
    {
        //variables to store apartment details
        int unit, floor;
        String parking;
        bool isValid;
        var address = GetValidAddress();
        double price = ReadDouble("Enter price: ");
        double squareFeet = ReadDouble("Enter square feet: ");
        int yearBuilt = ReadYearBuilt("Enter year built: ");
        //loop to ensure valid input for the apartment
        do
        {
            Console.WriteLine("Enter the apartment Unit number: ");
            isValid = int.TryParse(Console.ReadLine(), out unit);
            if (!isValid || unit < 0 || unit > 300)
                Console.WriteLine("Invalid number! Enter a valid number between 1 and 300");
        } while (!isValid || unit < 0 || unit > 300);

        do
        {
            Console.WriteLine("Enter the apartment floor number: ");
            isValid = int.TryParse(Console.ReadLine(), out floor);
            if (!isValid || floor < 0 || floor > 100)
                Console.WriteLine("Invalid number! Enter a valid number between 1 and 100");
        } while (!isValid || floor < 0 || floor > 100);

        do
        {
            Console.WriteLine("Is there parking available? : type \"yes\" or \"no\"");
            parking = Console.ReadLine().ToLower();
            if (parking != "yes" && parking != "no")
                Console.WriteLine("Invalid value! Enter \"yes\" or \"no\"");
        } while (parking != "yes" && parking != "no");

        //returning a new apartment object with the provided details
        return new Condo(price, squareFeet, yearBuilt, address, unit, floor, parking);
    }

    //method to display menu and get user choice
    public static int Menu()
    {
        int choice = 0;
        bool isValidInput;

        //loop to ensure valid input for menu choice
        do
        {
            Console.WriteLine("Enter 1: to add a House");
            Console.WriteLine("Enter 2: to add an apartment");
            Console.WriteLine("Enter 3: to quit");
            Console.WriteLine("Enter Your Choice: ");

            string userInput = Console.ReadLine();
            isValidInput = !string.IsNullOrWhiteSpace(userInput) && int.TryParse(userInput, out choice) && (choice >= 1 && choice <= 3);

            if (!isValidInput)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.\n");
            }
        } while (!isValidInput);

        return choice;
    }

    //method to get a valid address from the user
    static Address GetValidAddress()
    {
        string street = ReadString("Enter valid Street Name: ");
        string city = ReadString("Enter valid Municipality Name: ");
        string region = ReadString("Enter valid Region Name: ");
        string postalCode = ReadPostal("Enter 6 character Postal Code: ");

        return new Address(street, city, region, postalCode);
    }

    //method to read the valid positive double value from the user
    static double ReadDouble(string prompt)
    {
        double value;
        bool isValidInput;

        do
        {
            Console.Write(prompt);
            string userInput = Console.ReadLine();
            isValidInput = double.TryParse(userInput, out value) && value >= 0;

            if (!isValidInput)
            {
                Console.WriteLine("Invalid input. Please enter a valid positive number.\n");
            }
        } while (!isValidInput);

        return value;
    }

    //method to read a valid string from the user
    static string ReadString(string prompt)
    {
        string value;
        bool isValidInput;

        do
        {
            Console.Write(prompt);
            value = Console.ReadLine();
            isValidInput = !string.IsNullOrWhiteSpace(value) && value.Length >= 4;

            if (!isValidInput)
            {
                Console.WriteLine("Invalid input. Please enter a valid length string\n");
            }
        } while (!isValidInput);

        return value.ToLower();
    }

    //method to read  the valid 6-charachter postal code
    static string ReadPostal(string prompt)
    {
        string value;
        bool isValidInput;

        do
        {
            Console.Write(prompt);
            value = Console.ReadLine();
            isValidInput = !string.IsNullOrWhiteSpace(value) && value.Length == 6;

            if (!isValidInput)
            {
                Console.WriteLine("Invalid input. Please enter a valid 6-character postal code without spaces.\n");
            }
        } while (!isValidInput);

        return value.ToLower();
    }

    //method to read a valid year built from the user
    static int ReadYearBuilt(string prompt)
    {
        int value;
        bool isValidInput;

        do
        {
            Console.Write(prompt);
            string userInput = Console.ReadLine();
            isValidInput = int.TryParse(userInput, out value) && value >= 1900 && value <= DateTime.Now.Year;

            if (!isValidInput)
            {
                Console.WriteLine("Invalid input. Please enter a valid year between 1900 and the current year.\n");
            }
        } while (!isValidInput);

        return value;
    }
}