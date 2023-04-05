using Exercício7.ConsoleApp;

internal class Program
{
    private static void Main(string[] args)
    {
        Salario salario = new Salario();
        Console.WriteLine("Informe o salario base: ");
        salario.salarioBase = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Informe o total de vendas: ");
        salario.totalVendas = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Informe a comissão a ser aplicada sobre as vendas (em % ): ");
        salario.comissao = decimal.Parse(Console.ReadLine());

        Console.WriteLine($"O salario total ficou: {salario.CalcularSalario()}");
    }
}