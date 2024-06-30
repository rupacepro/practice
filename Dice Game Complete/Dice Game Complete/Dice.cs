public class Dice
{
    private const int Side = 6;
    private readonly Random _random;
    public Dice(Random random)
    {
        _random = random;
    }

    public int roll()
    {
        return _random.Next(1, Side + 1);
    }
}