namespace TemperatureInfo.Extensions;

public static class FloatExtension
{
    public static string? ToTemperatureCelsius(this float? flt)
    {
        return flt == null ? "-" : flt.ToString() + " °C";
    }
}
