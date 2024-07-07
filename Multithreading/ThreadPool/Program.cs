
using System.Diagnostics;

Stopwatch stopwatch = Stopwatch.StartNew();

for(int i = 0; i < 100; i++)
{
    ThreadPool.QueueUserWorkItem(Print);
}

stopwatch.Stop();

Console.WriteLine("Took: " + stopwatch.ElapsedMilliseconds);

static void Print(object obj)
{
    Console.Write("A");

}