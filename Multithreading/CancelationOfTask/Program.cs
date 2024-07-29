

Console.WriteLine("Main thread's ID: " + Thread.CurrentThread.ManagedThreadId);

var cancelationTokenSource = new CancellationTokenSource();

Task task = Task.Run(
    () => NeverEndingMethod(cancelationTokenSource),
    cancelationTokenSource.Token);

string? userInput;

do
{
    userInput = Console.ReadLine();
} while (userInput != "cancel");

cancelationTokenSource.Cancel();

Thread.Sleep(2000);

Console.WriteLine("Program is finished");
Console.WriteLine();

static void NeverEndingMethod(CancellationTokenSource cancelationTokenSource)
{

    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
    while (true)
    {
        cancelationTokenSource.Token.ThrowIfCancellationRequested();
        Console.WriteLine("Working...");
        Thread.Sleep(1500);
    }
}