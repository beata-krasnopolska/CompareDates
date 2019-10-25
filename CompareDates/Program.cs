using System;

namespace CompareDates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program compares two dates and indicates whether the date is earlier, equal or later than the second date");

            Console.WriteLine("Add a date you want to compare in the format: yyyy/mm/dd");
            Console.WriteLine("Add a year:");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Add a month:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Add a day:");
            int day = int.Parse(Console.ReadLine());

            DateTime today = DateTime.Today;
            DateTime userDate = new DateTime(year, month, day);

            Compare myComp = new Compare();
            myComp.CompareDates(today, userDate);

            Console.ReadKey();
        }
    }
}
