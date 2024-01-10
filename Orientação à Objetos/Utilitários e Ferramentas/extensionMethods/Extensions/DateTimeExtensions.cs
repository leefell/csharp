using System.Globalization;

namespace Extensions
{
    internal static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisOBJ)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisOBJ);

            if(duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours.";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days.";
            }
        }
    }
}
