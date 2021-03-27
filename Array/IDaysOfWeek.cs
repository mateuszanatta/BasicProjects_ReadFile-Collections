using System;

namespace Array
{
  public interface IDaysOfWeek
  {
    string[] DaysOfWeekArray { get; set; }
    void CreateArrayWithDaysOfWeek();
    string FindDayOfWeek(int day);
    void ReplaceDayOfWeek(int dayNumber, string dayName);
  }
}