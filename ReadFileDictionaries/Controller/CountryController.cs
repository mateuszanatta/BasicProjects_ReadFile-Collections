using System;
using System.Collections.Generic;

namespace ReadFileDictionaries
{
  class CountryController
  {
    Dictionary<string, Country> countries;
    ICsvReader reader;

    public CountryController(CsvReader reader)
    {
      this.reader = reader;
    }

    public Dictionary<string, Country> ReadAllCountriesFromCsv()
    {
      countries = reader.ReadAllCountries();
      return countries;
    }
    public Country FindCountryByPopulationByCode(string code)
    {
      try{
        return countries[code];
      }catch{
        throw new CountryCodeNotFound();
      }
    }
  }

  class CountryCodeNotFound : Exception{}
}