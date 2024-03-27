namespace TemperatureInfo;

public class Program
{
    static void Main()
    {
        if (OperatingSystem.IsWindows())
            TemperatureInfoService.GetTemperatureInfo();
    }
}
