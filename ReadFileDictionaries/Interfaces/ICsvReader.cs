using System.Collections.Generic;

namespace ReadFileDictionaries
{
  interface ICsvReader
  {
    Dictionary<string, Country> ReadAllCountries();
  }
}
