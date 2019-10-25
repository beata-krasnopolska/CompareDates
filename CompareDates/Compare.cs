using System;

namespace CompareDates
{
    class Compare
    {
        public void CompareDates (DateTime today, DateTime userDate)
        {
                int result = DateTime.Compare(today, userDate);
                string description;

            if (result< 0)
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
            Console.WriteLine("{0} {1} {2}", today.ToString("d"), description, userDate.ToString("d"));
        }
    }
}
