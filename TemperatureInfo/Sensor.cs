namespace TemperatureInfo;

public class Sensor(string sensorName, float? sensorValue)
{
    public string SensorName { get; private set; } = sensorName;
    public float? SensorValue { get; private set; } = sensorValue;
}
