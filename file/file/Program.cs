var stopwatch = Stopwatch.StartNew();


var names = new Names();
var path = new PathBuilder().BuildFilePath();
var readWrite = new ReadWrite();

if (File.Exists(path))
{
    Console.WriteLine("Names file already exists. Loading names.");
    var nameList = readWrite.ReadFromTextFile(path);
    foreach (var name in nameList)
    {
        Console.WriteLine(name);
    }
}
else
{
    Console.WriteLine("Names file does not yet exist.");

    //let's imagine they are given by the user
    names.AddName("John");
    names.AddName("not a valid name");
    names.AddName("Claire");
    names.AddName("123 definitely not a valid name");

    Console.WriteLine("Saving names to the file.");
    readWrite.WriteToTextFile(path, names.NameList);
}
//Console.WriteLine(new Formatter().Format(names.NameList));

stopwatch.Stop();
Console.WriteLine($"hi: {stopwatch.ElapsedMilliseconds}");


Console.ReadLine();






