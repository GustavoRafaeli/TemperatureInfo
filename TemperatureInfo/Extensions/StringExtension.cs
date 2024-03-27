namespace TemperatureInfo.Extensions;

public static class StringExtension
{
    public static string OrDashIfEmpty(this string str)
    {
        return string.IsNullOrEmpty(str) ? "-" : str;
    }
}
