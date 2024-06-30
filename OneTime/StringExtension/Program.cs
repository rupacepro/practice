
//string nameList = @"Rupesh Shrestha
//Ramala Shrestha
//Mukesh Shrestha
//Bikram Shrestha
//Pramila Shrestha";

//Console.WriteLine(nameList.CountLine());



//public static class StringExtension
//{
//    public static int CountLine(this string str)
//    {
//        return str.Split(Environment.NewLine).Length;
//    }
//}





//Console.WriteLine(Seasons.Spring.Next());
//public enum Seasons
//{
//    Spring, 
//    Summer, 
//    Autumn,
//    Winter
//}

//public static class EnumExtension
//{
//    public static Seasons Next(this Seasons seasons )
//    {
//        int given = (int) seasons;
//        given = (given + 1)%4;
//        return (Seasons) given;

//    }
//}


var aList = new List<int>() { 1, 2, 3, 4, 5, 6 };
foreach(int item in (aList.TakeEverySecond())){
    Console.WriteLine(item);
}

public static class Exercise
{
    public static List<int> TakeEverySecond(this List<int> mylist)
    {
        var newList = new List<int>();
        for (int i = 0; i < mylist.Count; i++)
        {
            newList.Add(mylist[i]);
            i++;
        }
        return newList;
    }
}