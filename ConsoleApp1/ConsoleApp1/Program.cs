
int[] nums = { 1, 2, 3, 4, 5 };

int evenCount = NumberUtils.GetEvenCount(nums);

Console.WriteLine(evenCount);

class NumberUtils

{

    public static int GetEvenCount(int[] numbers)

    {

        int count = 0;

        foreach (int num in numbers)

        {

            if (num % 2 == 0)

            {

                count++;

            }

        }

        return count;

    }

}


