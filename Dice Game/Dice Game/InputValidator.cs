
internal class InputValidator
{
    public bool isValid(string userInput)
    {
        int i;
        if (int.TryParse(userInput, out i))
        {
            return true;
        }
        return false;
    }
}