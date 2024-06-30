Console.WriteLine("Enter integer: ");

string input = Console.ReadLine();

try
{
    var number = ParseStringToInt(input);
    Console.WriteLine(number);
}
catch(Exception ex)
{
    Console.WriteLine("Error Occured");
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("End");
}

Console.ReadKey();

int ParseStringToInt(string input)
{
    return int.Parse(input);
}
