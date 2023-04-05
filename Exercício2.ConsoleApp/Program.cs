using Exercício2.ConsoleApp;

internal class Program
{
    private static void Main(string[] args)
    {
        ConversorTemp conversor = new ConversorTemp();
        Console.WriteLine("Informe a temperatura em fahrenheit: ");
        conversor.temp = decimal.Parse(Console.ReadLine());

        Console.WriteLine($"A conversão para ceusius ficou: {conversor.temperaturaFinal()}");
    }
}