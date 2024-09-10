IBM1 example = new IBM1();
int[] input = { 2, 3, 4, 5, 7 };
Console.WriteLine(example.Operation(input.ToList()));
public class IBM1
{
    public int Operation(List<int> ints)
    {
        int totalCost = 0;
        ints.Sort();
        while(ints.Count > 1)
        {
            double lowest = (double)ints[0];
            double highest = (double)ints[ints.Count - 1];
            int sum = (int)(lowest + highest);
            int cost = (int)Math.Ceiling((double)sum / (highest - lowest + 1));
            ints.RemoveAt(0);
            ints.RemoveAt(ints.Count - 1);
            ints.Add(sum);
            totalCost += cost;
        }
        return totalCost;
    }
}