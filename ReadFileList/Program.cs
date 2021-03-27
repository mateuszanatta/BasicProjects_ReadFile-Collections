using System;
using System.Collections.Generic;

namespace ReadFile
{
  class Program
  {
    static void Main(string[] args)
    {
      string filePath = @"..\Pop by Largest Final.csv";
      CsvReader reader = new CsvReader(filePath);

      CountryController countryController = new CountryController(reader);

      List<Country> countries = countryController.ReadAllCountriesFromCsv();

      Country liliput = new Country("Liliput", "LIL", "Somewhere", 2_000_000);
      int lilliputIndex = countryController.FindCountryByPopulationByIndex(liliput.Population);
      countryController.InsertCountryByIndex(lilliputIndex, liliput);

      countryController.RemoveCountryByIndex(lilliputIndex);

      PrintCountries(countries);
    }

    private static void PrintCountries(List<Country> countries)
    {
      Console.WriteLine("     Population: Country");
      foreach (Country country in countries)
      {
        string formatedPopulation = PopulationFormatter.FormatPopulation(country.Population).PadLeft(15);
        Console.WriteLine($"{formatedPopulation}: {country.Name}");
      }
      Console.WriteLine($"Countries:{countries.Count}");
    }
  }
}
