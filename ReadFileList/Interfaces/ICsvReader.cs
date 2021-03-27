using System.Collections.Generic;

namespace ReadFile
{
  interface ICsvReader
  {
    List<Country> ReadAllCountries();
  }
}
