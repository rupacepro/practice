
Console.WriteLine("Program is started.");

Task task = Task.Run(() => MethodThrowingException())
    .ContinueWith(faultedTask => 
    Console.WriteLine(faultedTask.Exception.Message),
    TaskContinuationOptions.OnlyOnFaulted);


Thread.Sleep(1000);
Console.WriteLine("Program is finished.");
Console.ReadKey();



static void MethodThrowingException()
{
    Console.WriteLine("Inside method.");
    Console.WriteLine("Hi");
    throw new Exception("Exception!!!!!!!");

}