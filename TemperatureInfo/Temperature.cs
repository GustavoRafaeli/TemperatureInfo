using TemperatureInfo.Extensions;

namespace TemperatureInfo;

public class Temperature
{
    public string HardwareName { get; set; }
    public string HardwareType { get; set; }
    public List<Sensor> Sensor { get; set; }

    public override string? ToString()
    {
        int padWidth = 15;

        if (Sensor == null)
            return "\nHardware Name".PadRight(padWidth) + $": {HardwareName.OrDashIfEmpty()}\n" +
                            "No temperature sensors detected!\n";

        var temperatureString = "Hardware Name".PadRight(padWidth) + $": {HardwareName.OrDashIfEmpty()}\n" +
                "Hardware Type".PadRight(padWidth) + ": " + HardwareType.OrDashIfEmpty() + "\n";

        foreach (var sensor in Sensor)
        {
            temperatureString += "\tSensor Name".PadRight(padWidth) + $": {sensor.SensorName.OrDashIfEmpty()}\n" +
                                "\tTemperature".PadRight(padWidth) + $": {sensor.SensorValue.ToTemperatureCelsius()}\n";
        }

        return temperatureString;
    }
}
