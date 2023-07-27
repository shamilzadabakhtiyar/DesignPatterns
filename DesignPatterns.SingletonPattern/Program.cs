using DesignPatterns.SingletonPattern;

Console.WriteLine(DateTime.Now.ToLongTimeString());
var countries = await CountryProvider.Instance.GetCountries();
//var countries = countryProvider.GetCountries().GetAwaiter().GetResult();

foreach (var country in countries)
    Console.WriteLine(country.Name);

var countries2 = await CountryProvider.Instance.GetCountries();
Console.WriteLine(DateTime.Now.ToLongTimeString());
