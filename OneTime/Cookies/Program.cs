
Cookie cookie = new Cookie();
var ingredients = new List<Ingredient>() {
    new WheatFlour(),
    new CoconutFlour(),
    new Butter(),
    new Chocolate(),
    new Sugar(),
    new Cardamom(),
    new Cinnamon(),
    new CocoaPowder()
};
const string FileName = "recipe";

//const FileFormat fileFormat = FileFormat.txt;

if (File.Exists($"{FileName}.txt"))
{
    Console.WriteLine("Existing recipes are:\n");
    var file = File.ReadAllLines("recipe.txt");
    var i = 1;
    foreach(var line in file)
    {
        Console.WriteLine("**********{0}**********", i);
        var list = line.Split(',');
        foreach(var item in list)
        {
            Ingredient specificIngredient = ingredients[int.Parse(item) - 1];
            Console.WriteLine("{0}. {1}.", specificIngredient.name, specificIngredient.instruction());
        }
        i++;
        Console.WriteLine("");
    }
}
cookie.DisplayIngredients();


var recipe = new List<Ingredient>();

while (true)
{
    if(int.TryParse(cookie.GetIdFromUser(), out int userInput)){
        if (userInput > 0 && userInput <= ingredients.Count)
        {
            recipe.Add(ingredients[userInput - 1]);
            Console.WriteLine("Add an ingredient by its ID or type anything else if finished.");
        }
        else
        {
            Console.WriteLine("No recipe!!");
            break;
        }
    }
    else
    {
        Console.WriteLine("No recipe!!");
        break;
    }
    
}

if(recipe.Count > 0)
{
    cookie.AddToTextFile(recipe);
    Console.WriteLine("Recipe added:");
    foreach(Ingredient ingredient in recipe)
    {
        Console.WriteLine(ingredient.name);
    }

}
Console.ReadKey();

public class Cookie
{
    public void DisplayIngredients()
    {
        Console.WriteLine("Create a new cookie recipe! Available ingredients are:");
        Console.WriteLine("1. Wheat Flour");
        Console.WriteLine("2. Coconut flour");
        Console.WriteLine("3. Butter");
        Console.WriteLine("4. Chocolate");
        Console.WriteLine("5. Sugar");
        Console.WriteLine("6. Cardamon");
        Console.WriteLine("7. Cinnamon");
        Console.WriteLine("8. Cocoa powder");
        Console.WriteLine("Add an ingredient by its ID or type anything else if finished.");
    }

    public string GetIdFromUser() => Console.ReadLine();
    public void AddToTextFile(List<Ingredient> recipe)
    {
        var list = new List<int>();
        foreach(var a in recipe)
        {
            list.Add(a.id);
        }
        File.AppendAllText("recipe.txt", string.Join(",",list));
        File.AppendAllText("recipe.txt", Environment.NewLine);
    }
}

public abstract class Ingredient
{
    public virtual int id { get; set; }
    public virtual string name { get; set; }
    public abstract string instruction();
}

public class WheatFlour : Ingredient
{
    public override int id => 1;
    public override string name => "Wheat Flour";
    public override string instruction()
    {
        return "Sieve. Add to other ingredients";
    }
}

public class CoconutFlour : Ingredient
{
    public override int id => 2;
    public override string name => "Coconut Flour";
    public override string instruction()
    {
        return "Sieve. Add to other ingredients";
    }
}

public class Butter : Ingredient
{
    public override int id => 3;
    public override string name => "Butter";
    public override string instruction()
    {
        return "Melt on low heat. Add to other ingredients.";
    }
}

public class Chocolate : Ingredient
{
    public override int id => 4;
    public override string name => "Chocolate";
    public override string instruction()
    {
        return "Melt in a water bath. Add to ther ingredients.";
    }
}

public class Sugar : Ingredient
{
    public override int id => 5;
    public override string name => "Sugar";
    public override string instruction()
    {
        return "Add to other ingredients.";
    }
}

public class Cardamom : Ingredient
{
    public override int id => 6;
    public override string name => "Cardamom";
    public override string instruction()
    {
        return "Take half a teaspoon. Add to other ingredients.";
    }
}

public class Cinnamon : Ingredient
{
    public override int id => 7;
    public override string name => "Cinnamon";
    public override string instruction()
    {
        return "Take half a teaspoon. Add to other ingredients.";
    }
}

public class CocoaPowder : Ingredient
{
    public override int id => 8;
    public override string name => "Cocoa Powder";
    public override string instruction()
    {
        return "Add to other ingredients";
    }
}
