
try
{
    var result = GetFirstElement(new int[0]);
}
catch(ArgumentNullException ex)
{
   Console.WriteLine(ex.ToString());
}

Console.ReadKey();

int GetFirstElement(IEnumerable<int> numbers)
{
    foreach(int number in numbers)
    {
        return number;
    }
    throw new ArgumentNullException("The collection is null.");
}