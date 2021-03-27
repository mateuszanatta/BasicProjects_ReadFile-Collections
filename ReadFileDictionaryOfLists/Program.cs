using System;
using System.Collections.Generic;

namespace ReadFileDictionaryOfLists
{
  class Program
  {
    static CountryController countryController;
    static void Main(string[] args)
    {
      string filePath = @"..\Pop by Largest Final.csv";
      CsvReader reader = new CsvReader(filePath);

      countryController = new CountryController(reader);

      Dictionary<string,List<Country>> countries = countryController.ReadAllCountriesFromCsv();

      PrintCountries(countries);
    }

    private static void PrintCountries(Dictionary<string,List<Country>> countries)
    {
      string chosenRegion = SelectRegion(countries);

      if(countries.ContainsKey(chosenRegion)){

        List<Country> countriesList = countryController.FindCountryByCode(chosenRegion);
        
        foreach (Country country in countriesList)
        {
          string formatedPopulation = PopulationFormatter.FormatPopulation(country.Population).PadLeft(15);
          Console.WriteLine($"{formatedPopulation}: {country.Name}");
        }
      }else{
        Console.WriteLine($"That is not a valid Region!");
      }
      
    }

    private static string SelectRegion(Dictionary<string,List<Country>> countries){
      Console.WriteLine($"Regions");  
      foreach (string region in countries.Keys)
        Console.WriteLine(region);
      
      Console.WriteLine($"Which of the above regions do you want?");
      return Console.ReadLine();
    }
  }
}
