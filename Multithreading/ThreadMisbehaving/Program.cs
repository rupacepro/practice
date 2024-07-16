Calculator calculator = new Calculator();

var tasks = new List<Task>();

for(int i = 0; i < 10; i++)
{
    tasks.Add(Task.Run(() => calculator.Increase()));
}

for(int i = 0; i< 10; i++)
{
    tasks.Add(Task.Run(() => calculator.Decrease()));
}

Task.WaitAll(tasks.ToArray());

Console.WriteLine(calculator.num);

class Calculator
{
    public int num { get; set; }
    public void Increase()
    {
        num += 1;
    }
    public void Decrease()
    {
        num -= 1;
    }

}