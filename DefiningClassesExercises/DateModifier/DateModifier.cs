using System;

class DateModifier
{
    public static double CalculateDifference(string firstDate, string secondDate)
    {
        DateTime first = DateTime.ParseExact(firstDate, "yyyy MM dd", System.Globalization.CultureInfo.InvariantCulture);
        DateTime second = DateTime.ParseExact(secondDate, "yyyy MM dd", System.Globalization.CultureInfo.InvariantCulture);
        TimeSpan diff = (first - second);
        return Math.Abs(diff.Days);
    }
}

