
var human = new Human();
human.travel();

public interface ITravel
{
    void travel();
}


public class Human : ITravel
{
    public void travel()
    {
        Console.WriteLine("Human can travel.");
    }
}

public class Vehicle: ITravel
{
    public void travel()
    {
        Console.WriteLine("We can travel using vehicle.");
    }
}