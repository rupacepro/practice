string s = "Rupesh";
List<char> name = s.ToList();
name.Remove('R');
foreach (char c in name)
{
    Console.WriteLine(c);
}

Console.WriteLine(s.Substring(0, 1));
