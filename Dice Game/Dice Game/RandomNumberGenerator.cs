

public class RandomNumberGenerator
{
    Random rd = new Random();
    public int generate()
    {
        return rd.Next(1, 7);
    }
}