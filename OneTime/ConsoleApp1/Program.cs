List<int> data = new List<int> { 1, 2, 3, 4, 5, 6 };

bool calculateonlyEven = false;

var calculator = calculateonlyEven ? new CalculateSumOfOnlyEvenNumbers() : new CalculateSum();
Console.WriteLine(calculator.calculate(data));

Console.ReadKey();
public class CalculateSum
{
    public int calculate(List<int> data)
    {
        int sum = 0;
        foreach (int i in data)
        {
            if (addItem(i))
            {
                sum += i;
            }
        }
        return sum;
    }

    public virtual bool addItem(int item) { return true; }
}

public class CalculateSumOfOnlyEvenNumbers: CalculateSum
{
    public override bool addItem(int item) {
        return item % 2 == 0;
    }
}