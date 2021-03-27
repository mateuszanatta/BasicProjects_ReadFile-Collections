using System;
using System.Collections.Generic;
using System.Linq;

namespace ReadFileDictionaryOfLists
{
  class CountryController
  {
    Dictionary<string, List<Country>> countries;
    ICsvReader reader;

    public CountryController(ICsvReader reader)
    {
      this.reader = reader;
    }

    public Dictionary<string, List<Country>> ReadAllCountriesFromCsv()
    {
      countries = reader.ReadAllCountries();
      return countries;
    }
    public List<Country> FindCountryByCode(string code)
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