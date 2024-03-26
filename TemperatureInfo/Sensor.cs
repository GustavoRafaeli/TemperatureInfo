namespace TemperatureInfo
{
    public class Sensor
    {
        public string SensorName { get; set; }
        public float? SensorValue { get; set; }

        public Sensor(string sensorName, float? sensorValue)
        {
            SensorName = sensorName;
            SensorValue = sensorValue;
        }
    }
}
