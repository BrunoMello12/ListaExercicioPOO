using Exercício4.ConsoleApp;

internal class Program
{
    private static void Main(string[] args)
    {
        ConsumoMedio consumo = new ConsumoMedio();

        Console.WriteLine("Informe o km inicial: ");
        consumo.kmI = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Informe o km final: ");
        consumo.kmF = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Informe o consumo de combustivel (em litros): ");
        consumo.gasolina = decimal.Parse(Console.ReadLine());

        Console.WriteLine($"O consumo médio foi: {consumo.CalcularConsumo()}");
    }
}