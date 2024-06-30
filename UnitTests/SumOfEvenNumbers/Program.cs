public static class SumOfEvenNumbers
{
    public static int Calculate(this IEnumerable<int> numbers)
    {
        int sum = 0;
        foreach (var number in numbers)
        {
            if(number % 2 == 0)
            {
                sum += number;
            }
        }
        return sum;
    }
}