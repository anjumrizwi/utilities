namespace MicroMethod
{
    #region Usings
    using System;
    using System.Globalization;
    #endregion
    /// <summary>
    /// DateExtension Class
    /// </summary>
    public static class DateExtension
    {
        public static long ToUnixTimestamp(this DateTime target)
        {
            var date = new DateTime(1970, 1, 1, 0, 0, 0, target.Kind);
            var unixTimestamp = Convert.ToInt64((target - date).TotalSeconds);

            return unixTimestamp;
        }

        public static DateTime ToDateTime(this DateTime target, long timestamp)
        {
            var dateTime = new DateTime(1970, 1, 1, 0, 0, 0, target.Kind);

            return dateTime.AddSeconds(timestamp);
        }

        public static bool IsBetweenTwoDates(DateTime target, DateTime start, DateTime end)
        {
            return (target.Ticks >= start.Ticks && target.Ticks <= end.Ticks);
        }

        public static DateTime ConvertDate(string dateToConvert)
        {
            DateTime toReturn;
            DateTime.TryParse(dateToConvert, CultureInfo.CurrentCulture, DateTimeStyles.None, out toReturn);

            return toReturn;
        }
    }
}

