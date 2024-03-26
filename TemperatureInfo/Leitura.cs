using LibreHardwareMonitor.Hardware;

namespace TemperatureInfo
{
    public class Leitura
    {
        public class UpdateVisitor : IVisitor
        {
            public void VisitComputer(IComputer computer)
            {
                computer.Traverse(this);
            }
            public void VisitHardware(IHardware hardware)
            {
                hardware.Update();
                foreach (IHardware subHardware in hardware.SubHardware) subHardware.Accept(this);
            }
            public void VisitSensor(ISensor sensor) { }
            public void VisitParameter(IParameter parameter) { }
        }

        public void Monitor()
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

            foreach (IHardware hardware in computer.Hardware)
            {
                Console.WriteLine("\nHardware: {0}", hardware.Name);

                foreach (IHardware subhardware in hardware.SubHardware)
                {
                    Console.WriteLine("\tSubhardware: {0}", subhardware.Name);

                    foreach (ISensor sensor in subhardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature)
                        {
                            Console.WriteLine("\t\t{0}, temperature: {1}, type: {2} ", sensor.Name, sensor.Value);
                        }
                    }
                }
                if (!hardware.Sensors.Any(sensor => sensor.SensorType == SensorType.Temperature))
                {
                    Console.WriteLine("No temperature sensors detected!");
                }

                foreach (ISensor sensor in hardware.Sensors)
                {

                    if (sensor.SensorType == SensorType.Temperature)
                    {
                        Console.WriteLine("\t{0}, temperautre: {1}", sensor.Name, sensor.Value);
                    }
                }
            }

            computer.Close();
        }
    }
}
