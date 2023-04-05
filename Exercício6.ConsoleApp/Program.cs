using Exercício6.ConsoleApp;

internal class Program
{
    private static void Main(string[] args)
    {
        ConverterTemperatura conversor = new ConverterTemperatura();
        Console.WriteLine("Informe a temperatura em graus celsius: ");
        conversor.celsius = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"A conversão para fahrenheit ficou: {conversor.ConverterCelsius()}");
    }
}