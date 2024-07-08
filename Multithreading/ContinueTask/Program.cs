
Task task = Task.Run(() =>
CalculateLength("Hello")).
ContinueWith(taskWithResult =>
Format(taskWithResult.Result)).ContinueWith(result => Console.WriteLine(result.Result));


string str;
do
{
    Console.WriteLine("Enter a string: ");
    str = Console.ReadLine();
} while (str != "exit");


Console.WriteLine("Program is finished!");



static int CalculateLength(string input)
{
    Console.WriteLine("Thread ID: " + Thread.CurrentThread.ManagedThreadId);
    Thread.Sleep(5000);
    return input.Length;
}

 static string Format(int length)
{
    return $"Length of the string is {length}";
}