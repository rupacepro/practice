for (int i = 0; i < 10; i++)
{
    Console.WriteLine(PasswordGenerator.Generate(new Bound(5, 8), true));
}
Console.ReadKey();

public class PasswordGenerator
{
    private static readonly Random _random = new Random();

    public static string Generate(
        Bound bound, bool shallUseSpecialCharacter)
    {
        var length = _random.Next(bound.minLength, bound.maxLength + 1);

        var characterToBeIncluded = shallUseSpecialCharacter ?
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_-+=" :
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        return new string(Enumerable.Repeat(characterToBeIncluded, length)
            .Select(characters => characters[_random
            .Next(characters.Length)])
            .ToArray());
    }


}

public struct Bound
{
    public int minLength { get; }
    public int maxLength { get; }
    public Bound(int minLength, int maxLength)
    {
        this.minLength = minLength;
        this.maxLength = maxLength;
        validateLength();
    }

    private void validateLength()
    {
        if (minLength < 1)
        {
            throw new ArgumentOutOfRangeException(
                $"leftRange must be greater than 0");
        }
        if (minLength > maxLength)
        {
            throw new ArgumentOutOfRangeException(
                $"leftRange must be smaller than rightRange");
        }
    }
}



