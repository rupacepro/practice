////var vehicle1 = new Vehicle();
////vehicle1.assignValue();
////Console.WriteLine(vehicle1.Id);

////var car1 = new Car();
////car1.assignValue();
////car1.print();


//Vehicle vehicle = new Vehicle();
//Console.WriteLine(vehicle.Id);

//Car car = new Car();
//Vehicle carVehicle = new Car();
//Console.WriteLine(carVehicle.Id);

//Bike bike = new Bike();
//Vehicle bikeVehicle = new Bike();
//Console.WriteLine(bikeVehicle.Id);


//public class Vehicle
//{
//    public virtual int Id { get; set; } = 101;
//    public void assignValue()
//    {
//        Id = 1;
//    }
//    public void print()
//    {
//        Console.WriteLine(Id);
//    }
//}

//public class Car : Vehicle
//{
//    //public override int Id => 1;
//    public void print()
//    {
//        //Console.WriteLinke(Id);
//    }
//}

//public class Bike : Vehicle
//{
//    public override int Id => 2;
//}




var duck = new Duck();
Animal animal = new Animal();
Console.WriteLine(animal.bark());
Animal lion = new Lion();
Console.WriteLine(lion.bark());


if (duck is Animal animal1)
{
    Console.WriteLine(animal1.ToString());
}

public class Exercise
{
    public void GetCountsOfAnimalsLegs()
    {
        var animals = new List<Animal>
            {
                new Lion(),
                new Tiger(),
                new Duck(),
                new Spider()
            };

        var result = new List<int>();
        foreach (var animal in animals)
        {
            result.Add(animal.NumberOfLegs);
        }
        foreach(var res in result)
        {
            Console.WriteLine(res);
        }
        
    }
}

class Animal
{
    public virtual int NumberOfLegs { get; set; } = 4;
    public virtual string bark()
    {
        return ("Myaaaa");
    }
}
class Lion : Animal
{
    public override string bark()
    {
        return("Aiiinnnn");
    }
}
class Tiger : Animal
{

}
class Duck : Animal
{
    public override int NumberOfLegs => 2;
}
class Spider : Animal
{
    public override int NumberOfLegs => 8;
}