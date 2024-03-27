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
        sb.AppendLine($"\nHardware Name: {HardwareName.OrDashIfEmpty()}");
        sb.AppendLine($"Hardware Type: {HardwareType.OrDashIfEmpty()}");

        if (Sensors == null || !Sensors.Any())
        {
            sb.AppendLine("No temperature sensors detected!\n");
            return sb.ToString().TrimEnd();
        }

        foreach (var sensor in Sensors)
        {
            sb.AppendLine($"\tSensor Name: {sensor.SensorName.OrDashIfEmpty()}")
              .AppendLine($"\tTemperature: {sensor.SensorValue.ToTemperatureCelsius()}")
              .AppendLine($"\t_________________________________________________________");
        }

        return sb.ToString().TrimEnd();
    }
}
