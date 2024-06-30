public class TrackChances
{
    int chances = 3;
    public bool haveChances()
    {
        if (chances > 0)
        {
            chances--;
            return true;
        }
        return false;
    }
    public void reduce()
    {
        chances--;
    }
}