


public class ConsoleReader: IUserInteractor
{
    public string ReadSingleWord(string message)
    {
        string? input;
        do
        {
            Console.WriteLine(message);
            input = Console.ReadLine();
        } while (!IsValidWord(input));
        return input;
    }

    public int ReadInteger(string message)
    {
        string input;
        do
        {
            Console.WriteLine(message);
            input = Console.ReadLine();
        } while (!IsValidInt(input));
        return int.Parse(input);
    }

    private bool IsValidInt(string? input)
    {
        return int.TryParse(input, out int result);
    }

    private bool IsValidWord(string? input)
    {
        return input is not null &&
            input.All(char.IsLetter);
    }

    public bool ReadBool(string message)
    {
        Console.WriteLine(message);
        string input = Console.ReadLine();
        if(input == "yes")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
}

