//var names = new Names();
//var path = names.BuildFilePath();

//if (File.Exists(path))
//{
//Console.WriteLine("Names file already exists. Loading names.");
//names.ReadFromTextFile();
//}
//else
//{
//Console.WriteLine("Names file does not yet exist.");

////let's imagine they are given by the user
//names.AddName("JohnBahadurSharma");
//names.AddName("not a valid name");
//names.AddName("Claire");
//names.AddName("123 definitely not a valid name");

//Console.WriteLine("Saving names to the file.");
//names.WriteToTextFile();
//}
////Console.WriteLine(names.Format());

//Console.ReadLine();

//public class Names
//{
//    private readonly List<string> _names = new List<string>();

//    public void AddName(string name)
//    {
//        if (IsValidName(name))
//        {
//            _names.Add(name);
//        }
//    }

//    private bool IsValidName(string name)
//    {
//        return
//            name.Length >= 2 &&
//            name.Length < 25 &&
//            char.IsUpper(name[0]) &&
//            name.All(char.IsLetter);
//    }

//    public void ReadFromTextFile()
//    {
//        var fileContents = File.ReadAllText(BuildFilePath());
//        var namesFromFile = fileContents.Split(Environment.NewLine).ToList();
//        foreach (var name in namesFromFile)
//        {
//            AddName(name);
//        }
//    }

//    public void WriteToTextFile() =>
//        File.WriteAllText(BuildFilePath(), Format());

//    public string BuildFilePath()
//    {
//        //we could imagine this is much more complicated
//        //for example that path is provided by the user and validated
//        return "files.txt";
//    }

//    public string Format() =>
//        string.Join(Environment.NewLine, _names);
//}


using System.Xml.Linq;

var names = new Name();
var pathCreater = new PathCreater();
var path = pathCreater.createPath();
var readWrite = new ReadWriteFile();

if (Path.Exists(path))
{
    Console.WriteLine($"{path} already exists!");
    foreach(var item in readWrite.readFromFile(path))
    {
        Console.WriteLine(item);
    }
}
else
{
    Console.WriteLine($"{path} does not exist");
    names.addNames("Rupesh");
    names.addNames("Ramala");
    names.addNames("Bikram");
    names.addNames("Pramila");
    names.addNames("Mukesh");
    names.addNames("unknown");
    Console.WriteLine($"Writing on {path}");
    readWrite.writeOnFile(path, names.Names);
}
Console.ReadKey();
class Name
{
    public List<String> Names { get; } = new List<String>();

    public void addNames(String name)
    {
        if (new NameValidator().isValidName(name))
        {
            Names.Add(name);
        }
    }
}