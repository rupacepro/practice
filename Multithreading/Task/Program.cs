
Console.WriteLine(Environment.ProcessorCount);
Console.WriteLine($"Main thread's Id: {Thread.CurrentThread.ManagedThreadId}");

Task task = new Task(() => PrintPlus(200));
Task task1 = new Task(()=> PrintMinus(200));
task.Start();
task1.Start();

Task.WaitAll(task, task1);

Console.WriteLine("Program is finished.");


Console.WriteLine();


static void PrintMinus(int n)
{
    Console.WriteLine($"Minus Printing ThreadID: {Thread.CurrentThread.ManagedThreadId}");

    for (int i = 0; i < n; i++)
    {
        Console.Write('-');
    }
}

static void PrintPlus(int n)
{
    Console.WriteLine($"Plus Printing ThreadID: {Thread.CurrentThread.ManagedThreadId}");

    for (int i = 0; i < n; i++)
    {
        Console.Write('+');
    }
}