using System.Collections.Generic;

namespace ReadFileDictionaryOfLists
{
  interface ICsvReader
  {
    Dictionary<string, List<Country>> ReadAllCountries();
  }
}
