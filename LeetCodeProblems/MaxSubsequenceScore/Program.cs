
int[] num1 = [23, 16, 20, 7, 3];
int[] num2 = [19, 21, 22, 22, 12];
int k = 3;

Solution Solution = new Solution();
long result = Solution.MaxScore(num1, num2, k);
Console.WriteLine(result);

public class Solution
{
    public long MaxScore(int[] nums1, int[] nums2, int k)
    {
        int n = nums1.Length;
        var pairs = new List<(int, int)>(n);
        for (int i = 0; i < n; i++)
        {
            pairs.Add((nums1[i], nums2[i]));
        }
        pairs.Sort((a, b) => a.Item2.CompareTo(b.Item2));

        PriorityQueue<(int, int), int> pq = new PriorityQueue<(int, int), int>();

        long sum = 0;
        int min = 0;
        long maxValue = 0;
        for (int i = 0; i < pairs.Count; i++)
        {
            var (a, b) = pairs[i];

            pq.Enqueue((a, b), b);
            sum = sum + a;
            //if (pq.Count > k)
            //{
            //    var (first, second) = pq.Dequeue();
            //    Console.WriteLine(first + ", " + second);
            //    sum -= first;
            //}
            if (pq.Count == k)
            {
                long minNum2 = pq.Peek().Item2;
                long possibleMax = sum * minNum2;
                maxValue = Math.Max(maxValue, possibleMax);
                var (first, second) = pq.Dequeue();
                Console.WriteLine(first + " " + second);
                sum -= first;
            }
        }
        return maxValue;
    }
}