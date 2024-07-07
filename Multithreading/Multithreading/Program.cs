﻿
Console.WriteLine(Environment.ProcessorCount);
Console.WriteLine($"Main thread's Id: {Thread.CurrentThread.ManagedThreadId}");

Thread thread1 = new Thread(() => PrintMinus(200));
Thread thread2 = new Thread(() => PrintPlus(200));

thread1.Start();

thread2.Start();

Console.WriteLine("Program is finished.");


Console.WriteLine();


static void PrintMinus(int n)
{
    Console.WriteLine($"Minus Printing ThreadID: {Thread.CurrentThread.ManagedThreadId}");

    for (int i = 0; i< n; i++)
    {
        Console.Write('-');
    }
}

static void PrintPlus(int n)
{
    Console.WriteLine($"Plus Printing ThreadID: {Thread.CurrentThread.ManagedThreadId}");

    for (int i = 0; i< n; i++)
    {
        Console.Write('+');
    }
}