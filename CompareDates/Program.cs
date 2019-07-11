using System;

namespace CompareDates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program compares two dates and indicates whether the date is earlier, equal or later than the second date");

            DateTime date1 = new DateTime(2019, 5, 17, 12, 0, 0);
            DateTime date2 = new DateTime(2017, 6, 14, 0, 0, 0);

            int result = DateTime.Compare(date1, date2);
            string description;

            if (result < 0)
            {
                description = "is earlier than";
            }
            else if (result == 0)
            {
                description = "is equal to";
            }
            else
            {
                description = "is later than";
            }
            Console.WriteLine("{0} {1} {2}", date1, description, date2);
            Console.ReadKey();
        }
    }
}
