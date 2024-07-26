
using System.Diagnostics;
using System.Text.Json;

var consoleReader = new ConsoleReader();

try
{
    string wordToSearch = consoleReader.ReadSingleWord("What word are you looking for?");
    int numOfPages = consoleReader.ReadInteger("How many pages do you want to read?");
    int quotesPerPage = consoleReader.ReadInteger("How many quotes per page?");
    //bool shallProcessInParallel = consoleReader.ReadBool("shall process pages in parallel?");

    consoleReader.ShowMessage("Fetching data...");
    List<string> data = await FetchDataFromAllPagesAsync(
        numOfPages, quotesPerPage);
    consoleReader.ShowMessage("Data is ready.");

    //CALLING PROCESS METHOD
    Process(data, wordToSearch);
}
catch (Exception ex)
{
    Console.WriteLine("Exception thrown: " + ex.Message);
}

void Process(List<string> data, string wordToSearch)
{
    foreach(var page in data)
    {
        ProcessPage(page, wordToSearch);
    }
}

void ProcessPage(string page, string wordToSearch)
{
    var root = JsonSerializer.Deserialize<Root>(page);
    var quoteWithWord = root.data
        .Where(quote => ContainsWord(quote.quoteText, wordToSearch))
        .OrderBy(quote => quote.quoteText.Length)
        .FirstOrDefault();
    if(quoteWithWord == null)
    {
        Console.WriteLine("No Matching Found!");
    }
    else
    {
        Console.WriteLine(quoteWithWord.quoteText);
    }
    Console.WriteLine();
}

bool ContainsWord(string quoteText, string wordToSearch)
{
    char[] splitter = { ' ', '\t', '.', ',', '?', '\'', '"', ':', ';', '!'};
    var split = quoteText.Split(splitter);
    foreach(var word in split)
    {
        if(word == wordToSearch)
        {
            return true;
        }
    }
    return false;
}

async Task<List<string>> FetchDataFromAllPagesAsync(int numOfPages, int quotesPerPage)
{
    var result = new List<string>();
    using var mockQuotesApiDataReader = new MockQuotesApiDataReader();

    for (int i = 0; i < numOfPages; i++)
    {
        var responseBody = await mockQuotesApiDataReader.ReadAsync(i + 1, quotesPerPage);
        result.Add(responseBody);
    }
    return result;
}




