using System;

namespace ReadFile
{
  class Program
  {
    static void Main(string[] args)
    {
      string filePath = @"..\Pop by Largest Final.csv";
      CsvReader reader = new CsvReader(filePath);

      Country[] countries = reader.ReadFirstNCountries(10);

      PrintCountries(countries);
    }

    private static void PrintCountries(Country[] countries)
    {
      Console.WriteLine("     Population: Country");
      foreach (Country country in countries)
      {
        string formatedPopulation = PopulationFormatter.FormatPopulation(country.Population).PadLeft(15);
        Console.WriteLine($"{formatedPopulation}: {country.Name}");
      }
    }
  }
}
