Solution solution = new Solution();
int[] result = solution.AsteroidCollision(new int[] { 5, 10, -5 });

foreach (int i in result)
{
    Console.WriteLine(i);
}

public class Solution
{
    public int[] AsteroidCollision(int[] asteroids)
    {
        Stack<int> items = new Stack<int>();
        int current, last = 0;
        int n = asteroids.Length;
        for (int i = 0; i < n; i++)
        {
            current = asteroids[i];
            if (items.Count == 0 || (current > 0 && last > 0))
            {
                items.Push(current);
                last = items.Peek();
                continue;
            }
            last = items.Peek();
            if (Math.Abs(current) > Math.Abs(last))
            {
                items.Pop();
                items.Push(current);
            }
        }
        int[] result = items.ToArray();
        Array.Reverse(result);
        return result;
    }
}