using LibreHardwareMonitor.Hardware;

namespace TemperatureInfo;

public class UpdateVisitor : IVisitor
{
    public void VisitComputer(IComputer computer) { }
    public void VisitHardware(IHardware hardware) { }
    public void VisitSensor(ISensor sensor) { }
    public void VisitParameter(IParameter parameter) { }
}
