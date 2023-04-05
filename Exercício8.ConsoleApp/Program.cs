using Exercício8.ConsoleApp;

internal class Program
{
    private static void Main(string[] args)
    {
        LataOleo lata = new LataOleo();
        Console.WriteLine("Informe o raio: ");
        lata.raio = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe a altura: ");
        lata.altura = double.Parse(Console.ReadLine());
        Console.WriteLine($"O volume da lata de óleo é: {lata.CalcularVolume()}");
    }
}