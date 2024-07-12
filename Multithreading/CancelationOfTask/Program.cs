
Console.WriteLine("Main thread's ID: " + Thread.CurrentThread.ManagedThreadId);

Task task = Task.Run(() => NeverEndingMethod());

string userInput;

do
{
    userInput = Console.ReadLine();
} while (userInput != "cancel");

Console.WriteLine("Program is finished");
Console.WriteLine();

static void NeverEndingMethod()
{
    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
    while (true)
    {
        Console.WriteLine("Working...");
        Thread.Sleep(1000);
    }
}