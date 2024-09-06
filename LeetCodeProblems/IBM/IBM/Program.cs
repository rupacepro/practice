IBM example = new IBM();
int[] arr = { 2, 3, 4, 5, 7};
Console.WriteLine("Value is: " + example.Generate(arr));


public class IBM
{
    public int Generate(int[] arr)
    {
        List<int> ints = arr.ToList();
        int first = 0;
        int last = ints.Count - 1;
        int TotalCost = 0;
        while (ints.Count > 1)
        {
            double value = (((double)ints[first] + (double)ints[last]) / ((double)ints[last] - (double)ints[first] + 1));
            int element = ints[first] + ints[last];
            Console.WriteLine(value);
            double ceilingValue = Math.Ceiling(value);
            int result = (int) ceilingValue;
            TotalCost += result;
            ints.RemoveAt(first);
            ints.RemoveAt(ints.Count - 1);
            ints.Add(element);
            last = ints.Count - 1;
            foreach(int i in ints)
            {
                Console.WriteLine(i);
            }
        }
        return TotalCost;
    }
}