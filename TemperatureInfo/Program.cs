namespace TemperatureInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leitura da temperatura dos componentes do Computador: ");

            var Leitura = new Leitura();

            Leitura.Monitor();

            Console.ReadLine();
        }
    }
}
