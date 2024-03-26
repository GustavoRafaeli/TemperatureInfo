using LibreHardwareMonitor.Hardware;

namespace TemperatureInfo;

public static class TemperatureInfoService
{
    public static void GetTemperatureInfo()
    {
        Computer computer = new Computer
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

        foreach (IHardware hardware in computer.Hardware)
        {
            var temperature = new Temperature();

            temperature.HardwareName = hardware.Name;
            temperature.HardwareType = hardware.HardwareType.ToString();

            var sensorList = new List<Sensor>();

            foreach (ISensor sensor in hardware.Sensors)
            {
                if (sensor.SensorType == SensorType.Temperature)
                {
                    sensorList.Add(new Sensor(sensor.Name, sensor.Value));
                }
            }
            if (sensorList.Count > 0)
                temperature.Sensor = sensorList;

            temperatureList.Add(temperature);
        }

        computer.Close();

        temperatureList.ForEach(temperature =>
        {
            Console.WriteLine(temperature.ToString());
        });

    }
}
