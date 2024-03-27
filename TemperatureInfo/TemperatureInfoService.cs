using LibreHardwareMonitor.Hardware;

namespace TemperatureInfo;

public static class TemperatureInfoService
{
    public static void GetTemperatureInfo()
    {
        var computer = new Computer
        {
            IsCpuEnabled = true,
            IsGpuEnabled = true,
            IsMemoryEnabled = true,
            IsMotherboardEnabled = true,
            IsStorageEnabled = true
        };

        computer.Open();
        computer.Accept(new UpdateVisitor());

        var temperatureList = new List<Temperature>();

        foreach (var hardware in computer.Hardware)
        {
            var temperature = new Temperature(hardware.Name, hardware.HardwareType.ToString());

            var sensors = GetSensors(hardware);

            temperature.SetSensors(sensors);

            foreach (var subHardware in hardware.SubHardware)
            {
                var sensorsSub = GetSensors(subHardware);

                temperature.SetSensors(sensorsSub);
            }

            temperatureList.Add(temperature);
        }

        computer.Close();

        foreach (var temperature in temperatureList)
        {
            Console.WriteLine(temperature.ToString());
        }

        Console.ReadLine();
    }

    private static List<Sensor>? GetSensors(IHardware? hardware)
    {
        if (hardware == null)
            return null;

        return hardware.Sensors
                        .Where(sensor => sensor.SensorType == SensorType.Temperature)
                        .Select(sensor => new Sensor(sensor.Name, sensor.Value))
                        .ToList();
    }
}
