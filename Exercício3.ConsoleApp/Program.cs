using Exercício3.ConsoleApp;

internal class Program
{
    private static void Main(string[] args)
    {
        Volume volume = new Volume();

        Console.WriteLine("Informe o raio: ");
        volume.raio = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe a altura: ");
        volume.altura = double.Parse(Console.ReadLine());

        Console.WriteLine($"O volume do cilíndro ficou: {volume.CalcularVolume()}");
    }
}