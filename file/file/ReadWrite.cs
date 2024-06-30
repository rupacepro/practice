
//Console.WriteLine(new Formatter().Format(names.NameList));

class ReadWrite
{
    public List<string> ReadFromTextFile(string path)
    {
        var fileContents = File.ReadAllText(path);
        var namesFromFile = fileContents.Split(Environment.NewLine).ToList();
        return namesFromFile;
    }

    public void WriteToTextFile(string path, List<string> strings) =>
        File.WriteAllText(path, string.Join(Environment.NewLine, strings));
}






