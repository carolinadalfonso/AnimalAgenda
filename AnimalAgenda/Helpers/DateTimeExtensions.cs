using AnimalAgenda.Classes;
using System;

namespace AnimalAgenda.Helpers
{
    public static class DateTimeExtensions
    {
        public static DateTimeSpan Compare(this DateTime source, DateTime compare)
        {
            return DateTimeSpan.CompareDates(source, compare);             
        }

        public static string GetAge(this DateTime birthday)
        {
            DateTimeSpan span = DateTime.Now.Compare(birthday);
            string age = string.Empty;

            string yearString = span.Years == 1 ? "año" : "años";
            string monthString = span.Months == 1 ? "mes" : "meses";
            string dayString = span.Days == 1 ? "día" : "días";

            if (span.Years >= 1 && (span.Months >= 1 && span.Months < 12))
            {
                age = string.Format("{0} {1} y {2} {3}", span.Years, yearString, span.Months, monthString);
            }
            else if (span.Years >= 1 && (span.Months == 0 && span.Days >= 1))
            {
                age = string.Format("{0} {1} y {2} {3}", span.Years, yearString, span.Days, dayString);
            }
            else if (span.Years >= 1 && span.Days == 0)
            {
                age = string.Format("{0} {1} ¡Feliz Cumple!", span.Years, yearString);
            }
            else if (span.Years == 0 && (span.Months >= 1 && span.Months < 12))
            {
                age = string.Format("{0} {1}", span.Months, monthString);
            }
            else if (span.Months == 0 && span.Days > 0)
            {
                age = string.Format("{0} {1}", span.Days, dayString);
            }

            return age;
        }
    }
}
