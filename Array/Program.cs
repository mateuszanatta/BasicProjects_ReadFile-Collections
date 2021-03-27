using System;

namespace Array
{
  class Program
  {
    static void Main()
    {
      BaseDaysOfWeek daysOfWeek = new DaysOfWeek();
      daysOfWeek.CreateArrayWithDaysOfWeek();

      PrintDaysOfWeek(daysOfWeek);
      PrintChosenDayOfWeek(daysOfWeek);
      ReplaceDayOfWeek(daysOfWeek);

    }

    private static void PrintDaysOfWeek(IDaysOfWeek daysOfWeek)
    {
      foreach (var dayOfWeek in daysOfWeek.DaysOfWeekArray)
        Console.WriteLine(dayOfWeek);
    }

    private static void PrintChosenDayOfWeek(IDaysOfWeek daysOfWeek)
    {
      Console.WriteLine("Which day do you want to display?");
      Console.WriteLine("(Monday = 1), etc.");

      int dayNumber = int.Parse(Console.ReadLine());

      string chosenDay = daysOfWeek.FindDayOfWeek(dayNumber);
      Console.WriteLine($"That day is {chosenDay}");
    }

    private static void ReplaceDayOfWeek(IDaysOfWeek daysOfWeek)
    {
      Console.WriteLine("Which day do you want to replace?");
      Console.WriteLine("(Monday = 1), etc.");

      string dayToReplace = Console.ReadLine();
      int dayNumber = int.Parse(dayToReplace);

      Console.WriteLine("Type the New Name");
      string newName = Console.ReadLine();

      daysOfWeek.ReplaceDayOfWeek(dayNumber, newName);

      Console.WriteLine($"New Days");
      PrintDaysOfWeek(daysOfWeek);
    }
  }
}
