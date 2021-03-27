using System;
using System.IO;
using System.Collections.Generic;

namespace ReadFileDictionaryOfLists
{

  public class CsvReader : ICsvReader
  {
    private string csvFilePath { get; set; }
    private Dictionary<string, List<Country>> countries { get; set; }

    public CsvReader(string csvFilePath)
    {
      this.csvFilePath = csvFilePath;
    }

    public Dictionary<string, List<Country>> ReadAllCountries()
    {
      ReadAllLinesCsvFile();
      return countries;
    }

    private void ReadAllLinesCsvFile()
    {
      countries = new Dictionary<string, List<Country>>();

      using (StreamReader sr = new StreamReader(csvFilePath))
      {
        sr.ReadLine(); // read Header line

        string csvLine;
        while((csvLine = sr.ReadLine()) != null)
        {
          Country country = ReadCountryFromCsvFile(csvLine);
          if(countries.ContainsKey(country.Region))
          {
            countries[country.Region].Add(country);
          }
          else
          {
           countries.Add(country.Region, new List<Country>() { country });
          }

        }
      }
    }

    private Country ReadCountryFromCsvFile(string csvLine)
    {
      string[] parts = csvLine.Split(',');

      string countryName;
      string countryCode;
      string countryRegion;
      string population;
      
      //Since there are Country names with commas, this is
      // simple solution to overcome it.
      switch (parts.Length)
      {
        case 4:
          countryName = parts[0];
          countryCode = parts[1];
          countryRegion = parts[2];
          population = parts[3];
          break;
        case 5:
          countryName = parts[0];
          countryName = countryName.Replace("\"", null);
          countryCode = parts[2];
          countryRegion = parts[3];
          population = parts[4];
          break;
        default:
          throw new CsvWrongformat();
      }
      int.TryParse(population, out int countryPopulation);
      return new Country(countryName, countryCode, countryRegion, countryPopulation);
    }
  }

  class CsvWrongformat : Exception{}
}