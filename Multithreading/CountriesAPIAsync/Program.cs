

using System.Text.Json;

string URL = "https://restcountries.com/v3.1/all";
var countries = await GetCountries(URL);

var Nepal = countries.Where(country => country.name.common == "Nepal");

foreach(var country in Nepal)
{
    Console.WriteLine(country.landlocked);
}
Console.WriteLine("Program is finished.");
Console.ReadKey();

async Task<IEnumerable<Root>> GetCountries(string url)
{
    using var httpClient = new HttpClient();
    HttpResponseMessage response = await httpClient.GetAsync(url);
    response.EnsureSuccessStatusCode();

    string json = await response.Content.ReadAsStringAsync();

    var roots = JsonSerializer.Deserialize<List<Root>>(json);

    return roots;
}

// Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);

public record Name(
string common,
string official
);

public record Root(
Name name,
bool landlocked
);
