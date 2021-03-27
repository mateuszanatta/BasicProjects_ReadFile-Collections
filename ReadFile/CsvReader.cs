using System;
using System.IO;

namespace ReadFile
{
  public class CsvReader
  {

    private string csvFilePath;
    private Country[] countries;
    public CsvReader(string csvFilePath)
    {
      this.csvFilePath = csvFilePath;
    }

    public Country[] ReadFirstNCountries(int nCountries)
    {
      ReadNLinesCsvFile(nCountries);
      return countries;
    }

    private void ReadNLinesCsvFile(int nCountries)
    {
      countries = new Country[nCountries];

      using (StreamReader sr = new StreamReader(csvFilePath))
      {
        sr.ReadLine(); // read Header line

        for (int i = 0; i < nCountries; i++)
        {
          string csvLine = sr.ReadLine();
          countries[i] = ReadCountryFromCsvFile(csvLine);
        }
      }
    }

    private Country ReadCountryFromCsvFile(string csvLine)
    {
      string[] parts = csvLine.Split(',');

      string countryName = parts[0];
      string countryCode = parts[1];
      string countryRegion = parts[2];
      int countryPopulation = int.Parse(parts[3]);

      return new Country(countryName, countryCode, countryRegion, countryPopulation);
    }
  }
}