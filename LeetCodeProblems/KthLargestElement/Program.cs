

int[] arr = new int[] { 1, 2, 1, 6, 4, 7, 8, 3, 5, 6 };
int k = 4;

KthLargestElement example = new KthLargestElement();
int result = example.Find(arr, k);
Console.WriteLine(result);

public class KthLargestElement
{
    public int Find(int[] arr, int k)
    {
        PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>();
        foreach(int i in arr)
        {
            maxHeap.Enqueue(i, i);
        }
        for(int i =0; i < k - 1; i++)
        {
            maxHeap.Dequeue();
        }
        return maxHeap.Peek();
    }
}