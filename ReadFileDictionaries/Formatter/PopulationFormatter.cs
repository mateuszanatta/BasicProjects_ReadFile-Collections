//Provided by C# Collections Beginner at PluralSight
using System;

namespace ReadFileDictionaries
{
  public class PopulationFormatter
  {
    public static string FormatPopulation(int population)
    {
      if (population == 0)
        return "(Unknown)";

      int populationRounded = RoundPopulation(population);

      return $"{populationRounded:### ### ### ###}".Trim();
    }

    static int RoundPopulation(int population)
    {
      int roundAccuracy = Math.Max((int)(GetLowestPowerOfTenLargerThan(population) / 10_000L), 1);
      return RoundToNearest(population, roundAccuracy);
    }

    /// <summary>
		/// Returns the lowest number that is a power of 10 and is larger than the value supplied 
		/// Examples:
		/// GetLowestPowerOfTenLargerThan(11) = 100
		/// GetLowestPowerOfTenLargerThan(99) = 100
		/// GetLowestPowerOfTenLargerThan(100) = 1000
		/// GetLowestPowerOfTenLargerThan(843) = 1000
		/// GetLowestPowerOfTenLargerThan(1000) = 10000
		/// </summary>
		/// <param name="number"></param>
		/// <returns></returns>
    static long GetLowestPowerOfTenLargerThan(int population)
    {
      long result = 1;
      while (population > 0)
      {
        population /= 10;
        result *= 10;
      }

      return result;
    }

    /// <summary>
		/// Rounds the number to the specified accuracy
		/// For example, if the accuracy is 10, then we round to the nearest 10:
		///     23 -> 20 (rounded to nearest 10)
		///     25 -> 30 (rounded to nearest 10)
		///     etc.
		/// Note that we are following the convention that 0.5 rounds up to 1, but anything below 0.5 rounds down
		/// </summary>
		/// <param name="exact">The number to be rounded</param>
		/// <param name="accuracy">The required accuracy</param>
		/// <returns>The number rounded to the specified accuracy</returns>
    static int RoundToNearest(int population, int roundAccuracy)
    {
      int adjusted = population + roundAccuracy / 2;
      return adjusted - adjusted % roundAccuracy;
    }
  }

}