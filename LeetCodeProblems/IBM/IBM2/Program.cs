int[] speed = { 3, 2, 1 };
int minCom = 3;
int speedThreshold = 10;

Main example = new Main();
Console.WriteLine(example.FindMaxNumberOfNetWork(speed, minCom, speedThreshold));

public class Main
{
    public int FindMaxNumberOfNetWork(int[] speed, int minCom, int speedThreshhold)
    {
        int totalComputer = speed.Length;
        int countComputer = 0;
        int countSpeed = 0;
        int currentComputerIndex = 0;
        int countNetwork = 0;
        while(totalComputer > 0)
        {
            if (countComputer < minCom || countSpeed < speedThreshhold)
            {
                countSpeed += speed[currentComputerIndex];
                currentComputerIndex++;
                countComputer++;
                totalComputer--;
                if(countComputer >= minCom && countSpeed >= speedThreshhold) {
                    countNetwork++;
                    countComputer = 0;
                    countSpeed = 0;
                }
            }
        }
        return countNetwork;
    }
}