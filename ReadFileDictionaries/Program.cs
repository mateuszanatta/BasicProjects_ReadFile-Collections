using System;
using System.Collections.Generic;

namespace ReadFileDictionaries
{
  class Program
  {
    static void Main(string[] args)
    {
      string filePath = @"..\Pop by Largest Final.csv";
      CsvReader reader = new CsvReader(filePath);

      CountryController countryController = new CountryController(reader);

      Dictionary<string, Country> countries = countryController.ReadAllCountriesFromCsv();

      PrintCountries(countries);
      LookUpCountryByCode(countryController);
    }
    private static void PrintCountries(Dictionary<string, Country> countries)
    {
      Console.WriteLine("     Population: Country");
      foreach (Country country in countries.Values)
      {
        string formatedPopulation = PopulationFormatter.FormatPopulation(country.Population).PadLeft(15);
        Console.WriteLine($"{formatedPopulation}: {country.Name}");
      }
      Console.WriteLine($"Countries:{countries.Count}");
    }

    private static void LookUpCountryByCode(CountryController countryController)
    {
      Console.WriteLine("Which country code do you want to look up?");
      string userInput = Console.ReadLine();

      try
      {
        Country country = countryController.FindCountryByPopulationByCode(userInput);
        string formatedPopulation = PopulationFormatter.FormatPopulation(country.Population).PadLeft(15);
        Console.WriteLine($"{formatedPopulation}: {country.Name}");
      }
      catch (CountryCodeNotFound)
      {
        Console.WriteLine($"Sorry, there is no country with code: {userInput}");
      }
    }
  }
}
