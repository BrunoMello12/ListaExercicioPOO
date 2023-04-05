using ListaExercícioPOO.ConsoleApp;

internal class Program
{
    private static void Main(string[] args)
    {
        Caixa caixa = new Caixa();

        Console.WriteLine("Informe a altura da caixa: ");
        caixa.altura = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe a largura da caixa: ");
        caixa.largura = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o comprimento da caixa: ");
        caixa.comprimento = int.Parse(Console.ReadLine());

        Console.WriteLine($"O volume da caixa é: {caixa.CalcularVolume()}");
    }
}