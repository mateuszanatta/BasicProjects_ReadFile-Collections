using System;

namespace Array
{
  public class DaysOfWeek : BaseDaysOfWeek
  {
    public DaysOfWeek() : base()
    {
    }

    public override void CreateArrayWithDaysOfWeek()
    {
      DaysOfWeekArray = new string[7] {
        "Monday",
        "Tuesday",
        "Wednesday",
        "Thursday",
        "Friday",
        "Saturday",
        "Sunday"
      };
    }

    public override string FindDayOfWeek(int day)
    {
      try
      {
        return DaysOfWeekArray[--day];
      }
      catch
      {
        throw new DayOfWeekDoesNotExist();
      }
    }

    public override void ReplaceDayOfWeek(int dayNumber, string dayName)
    {
      DaysOfWeekArray[--dayNumber] = dayName;
    }
  }

  class DayOfWeekDoesNotExist : Exception { }
}
