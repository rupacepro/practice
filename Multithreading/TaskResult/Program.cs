

Task task1 = Task.Run(() =>
{
    Thread.Sleep(2000);
    Console.WriteLine("Task 1 Completed!");
});

Task task2 = Task.Run(() =>
{
    Thread.Sleep(1000);
    Console.WriteLine("Task 2 Completed!");
});

Task.WaitAll(task1, task2);

Console.WriteLine("Program is finished!");
Console.ReadKey();

static int Length(string input)
{
    Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}");
    Thread.Sleep(4000);
    return input.Length;
}

