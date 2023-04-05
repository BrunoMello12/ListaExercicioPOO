using Exercício5.ConsoleApp;

internal class Program
{
    private static void Main(string[] args)
    {
        VolumeEsfera volume = new VolumeEsfera();
        Console.WriteLine("Informe o raio: ");
        volume.raio = double.Parse(Console.ReadLine());
        Console.WriteLine($"O volume da esfera ficou: {volume.CalcularVolume()}");
    }
}