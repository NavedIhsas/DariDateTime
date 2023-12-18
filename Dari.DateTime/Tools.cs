namespace Dari.DateTime;

public static class Tools
{
    public static string GetFormat(this DateFormat dateFormat)
    {
        return dateFormat switch
        {
            DateFormat.YearMonthDay => "yyyy/MM/dd",
            DateFormat.YearMonthNameDay => "yyyy/MMMM/dd",
            DateFormat.YearDayMonthName => "yyyy/dd/MMMM",
            _ => throw new ArgumentOutOfRangeException(nameof(dateFormat), dateFormat, null)
        };
    }
}

public enum DateFormat
{
    /// <summary>
    ///     خروجی: "1402/09/27"
    /// </summary>
    YearMonthDay,

    /// <summary>
    ///     خروجی: 1402/قوس/27
    /// </summary>
    YearMonthNameDay,

    YearDayMonthName
}