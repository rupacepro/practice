

//Task.Run(() =>
//{
//    int length = CalculateLength("Rupesh");
//    Print(length);
//    Console.WriteLine("Process is finished.");
//});

//Task.Run(() => CalculateLength("Rupesh"))
//    .ContinueWith(length => Print(length.Result))
//    .ContinueWith(result => Console.WriteLine("Process is finished."));
Calculate();
Console.WriteLine("skiped the CalculateLength method.");
Console.ReadKey();

static async Task Calculate(){
    var length = await CalculateLength("Rupesh");
    Print(length);
}

string input;
do
{
    input = Console.ReadLine();
} while (input != "stop");

Console.WriteLine("Program has finished!");

static async Task<int> CalculateLength(string input)
{
    Console.WriteLine("Calculating Length...");
    await Task.Delay(2000);
    return input.Length;
}

static async void Print(int result)
{
    Console.WriteLine("Printing result...");
    await Task.Delay(2000);
    Console.WriteLine($"Length is {result}");
}



//Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
//var task = RunHeavyProcess();
//Console.WriteLine("Doing other work");
//Console.WriteLine("Doing even more work");
//await Task.Delay(2000);
//Console.WriteLine("hello");
//Console.ReadLine();


//static async Task RunHeavyProcess()
//{
//    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
//    var result = await HeavyCalculation();
//    Console.WriteLine(result);
//}

//static async Task<string> HeavyCalculation()
//{
//    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
//    Console.WriteLine("Starting heavy calculation");
//    await Task.Delay(2000);
//    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
//    return "Done!";
//}