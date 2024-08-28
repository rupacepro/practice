

Solution example = new Solution();
this input is not working
int[][] input = [
    [1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0],
    [0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0],
    [0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
    [0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0],
    [0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0],
    [0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0],
    [0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0],
    [0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0],
    [0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0],
    [1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0],
    [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0],
    [0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0],
    [0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0],
    [0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0],
    [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1]
    ];

//int[][] input = [[1, 0, 0],
//    [1, 1, 0],
//    [1, 1, 1],
//];
Console.WriteLine(example.FindCircleNum(input));

public class Solution
{
    public int FindCircleNum(int[][] isConnected)
    {
        if (isConnected == null)
        {
            return 0;
        }
        List<List<int>> provinces = new List<List<int>>();
        int citiesCount = isConnected.GetLength(0);
        int totalCities = 0;
        bool status = false;

        for (int i = 1; i < citiesCount; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (isConnected[i][j] == 0)
                {
                    continue;
                }
                foreach (List<int> province in provinces)
                {
                    if (province.Contains(i) && province.Contains(j))
                    {
                        status = true;
                        break;
                    }
                    else if (province.Contains(i))
                    {
                        province.Add(j);
                        totalCities++;
                        status = true;
                        break;
                    }
                    else if (province.Contains(j))
                    {
                        province.Add(i);
                        totalCities++;
                        status = true;
                        break;
                    }
                }
                if (status == false)
                {
                    provinces.Add(new List<int> { i, j });
                    totalCities += 2;
                }
            }
        }
        return (provinces.Count + citiesCount - totalCities);
    }
}