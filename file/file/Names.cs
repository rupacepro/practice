

public class Names
{
    public List<string> NameList { get; } = new List<string>();
    private readonly NameValidator _namesValidator = new NameValidator();
    public void AddName(string name)
    {
        if (_namesValidator.IsValid(name))
        {
            NameList.Add(name);
        }
    }

    public void AddNames()
    {
        throw new NotImplementedException();
    }
}
