using System.Globalization;

namespace Dari.DateTime;

public static class Extensions
{
    private static readonly string[] DariNumber = { "۰", "۱", "۲", "۳", "۴", "۵", "۶", "۷", "۸", "۹" };
    private static readonly string[] EnglishNumber = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

    /// <summary>
    /// تبدیل اعداد دری به انگلیسی
    /// </summary>
    /// <param name="strNum"></param>
    /// <returns>اعداد انگلیسی</returns>
    public static string ToEnglishNumber(this string strNum)
    {
        var cash = strNum;
        for (var i = 0; i < 10; i++)
            cash = cash.Replace(DariNumber[i], EnglishNumber[i]);
        return cash;
    }
    /// <summary>
    /// تبدیل انگلیسی به دری
    /// </summary>
    /// <param name="intNum"></param>
    /// <returns>اعداد دری</returns>
    public static string ToPersianNumber(this string intNum)
    {
        var chash = intNum.ToString();
        for (var i = 0; i < 10; i++)
            chash = chash.Replace(EnglishNumber[i], DariNumber[i]);
        return chash;
    }

    /// <summary>
    ///     تبدیل تاریخ میلادی به شمسی
    /// </summary>
    /// <param name="date">تاریخ میلادی</param>
    /// <param name="dateFormat">فرمت نمایش تاریخ شمسی (اختیاری)</param>
    /// <returns>1402/09/12 مثال خروجی</returns>
    public static string ToDari(this System.DateTime date, DateFormat dateFormat = DateFormat.YearMonthDay)
    {
        var format = dateFormat.GetFormat();
        return date.ToString(format, new CultureInfo("prs-AF"));
    }

    /// <summary>
    ///     تبدیل تاریخ میلادی به شمسی با فرمت دلخواه
    /// </summary>
    /// <param name="date">تاریخ میلادی</param>
    /// <param name="format">فرمت</param>
    /// <returns>yyyy/MMMM/dd</returns>
    public static string ToDari(this System.DateTime date, string format)
    {
        return date.ToString(format, new CultureInfo("prs-AF"));
    }

    /// <summary>
    ///     تبدیل تاریخ میلادی به شمسی با فرمت دلخواه
    /// </summary>
    /// <param name="dariDate">تاریخ میلادی</param>
    /// <returns>تاریخ میلادی</returns>
    public static System.DateTime? ToDariDateTime(this string dariDate)
    {
        if (string.IsNullOrEmpty(dariDate))
            return null;

        var spited = dariDate.Split('/');
        if (spited.Length < 3)
            return null;

        if (!int.TryParse(spited[0].ToEnglishNumber(), out var year))
            return null;

        if (!int.TryParse(spited[1].ToEnglishNumber(), out var month))
            return null;

        if (!int.TryParse(spited[2].ToEnglishNumber(), out var day))
            return null;
        var c = new PersianCalendar();
        return c.ToDateTime(year, month, day, 0, 0, 0, 0).Date;
    }

}