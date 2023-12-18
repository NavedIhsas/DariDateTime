using System.Globalization;

namespace Dari.DateTime;

public static class Extensions
{
    /// <summary>
    ///     تبدیل تاریخ شمسی به میلادی
    /// </summary>
    /// <param name="date">تاریخ میلادی</param>
    /// <param name="dateFormat">فرمت نمایش تاریخ شمسی (اختیاری)</param>
    /// <returns></returns>
    public static string ToDariDateTime(this System.DateTime date, DateFormat dateFormat = DateFormat.YearMonthDay)
    {
        var format = dateFormat.GetFormat();
        return date.ToString(format, new CultureInfo("prs-AF"));
    }

    /// <summary>
    ///     تبدیل تاریخ شمسی به میلادی با فرمت دلخواه
    /// </summary>
    /// <param name="date">تاریخ میلادی</param>
    /// <param name="format">فرمت</param>
    /// <returns></returns>
    public static string ToDariDateTime(this System.DateTime date, string format)
    {
        return date.ToString(format, new CultureInfo("prs-AF"));
    }
}