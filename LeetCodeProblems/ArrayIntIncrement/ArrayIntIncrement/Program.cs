//Solution example = new Solution();
//var input = new int[] { 7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4, 0, 0, 6 };
//int[] arr = example.PlusOne(input);
//foreach (int i in arr)
//{
//    Console.WriteLine(i);
//}

//public class Solution
//{
//    public int[] PlusOne(int[] digits)
//    {
//        int length = digits.Length;
//        long result = 0;
//        int index = 0;
//        for (int i = length - 1; i >= 0; i--)
//        {
//            if (i == 0)
//            {
//                result += digits[index] * 1;
//            }
//            else
//            {
//                result += digits[index] * (long)Math.Pow(10, i);
//            }
//            index++;
//        }
//        result++;
//        return result.ToString().Select(x => int.Parse(x.ToString())).ToArray();
//    }
//}





