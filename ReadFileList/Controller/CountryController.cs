using System;
using System.Collections.Generic;
using System.Linq;

namespace ReadFile
{
  class CountryController
  {
    List<Country> countries;
    ICsvReader reader;

    public CountryController(ICsvReader reader)
    {
      this.reader = reader;
    }

    public List<Country> ReadAllCountriesFromCsv()
    {
      countries = reader.ReadAllCountries();
      return countries.OrderBy(country => country.Name).ToList<Country>();
    }
    public int FindCountryByPopulationByIndex(int population)
    {
      return countries.FindIndex(country => country.Population < population);
    }

    public void InsertCountryByIndex(int index, Country country)
    {
      countries.Insert(index, country);
    }
    public void RemoveCountryByIndex(int index)
    {
      countries.RemoveAt(index);
    }
  }
}