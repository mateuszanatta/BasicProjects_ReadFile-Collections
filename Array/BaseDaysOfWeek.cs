using System;

namespace Array
{
  public abstract class BaseDaysOfWeek : IDaysOfWeek
  {
    public string[] DaysOfWeekArray { get; set; }
    public BaseDaysOfWeek()
    {
    }

    public abstract void CreateArrayWithDaysOfWeek();
    public abstract string FindDayOfWeek(int day);
    public abstract void ReplaceDayOfWeek(int dayNumber, string dayName);
  }
}