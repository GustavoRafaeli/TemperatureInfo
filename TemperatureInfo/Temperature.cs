using System.Text;
using TemperatureInfo.Extensions;

namespace TemperatureInfo;

public class Temperature
{
    public string HardwareName { get; private set; }
    public string HardwareType { get; private set; }
    public List<Sensor>? Sensors { get; private set; }

    public Temperature(string hardwareName, string hardwareType)
    {
        HardwareName = hardwareName;
        HardwareType = hardwareType;
    }

    public void SetSensors(List<Sensor>? sensors)
    {
        Sensors = sensors;
    }

    public override string? ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"{HardwareType.OrDashIfEmpty()}: {HardwareName.OrDashIfEmpty()}");

        if (Sensors == null || Sensors.Count == 0)
        {
            sb.AppendLine("No temperature sensors detected!");
            return sb.ToString();
        }

        foreach (var sensor in Sensors)
            sb.AppendLine($"\t{sensor.SensorName.OrDashIfEmpty()}: {sensor.SensorValue.ToTemperatureCelsius()}");

        return sb.ToString();
    }
}
