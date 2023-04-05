using Exercicio9_10.ConsoleApp;

internal class Program
{
    private static void Main(string[] args)
    {
        Aluno aluno = new Aluno();
        Console.WriteLine("informe a primeira nota: ");
        aluno.n1 = decimal.Parse(Console.ReadLine());
        Console.WriteLine("informe a segunda nota: ");
        aluno.n2 = decimal.Parse(Console.ReadLine());
        Console.WriteLine("informe a terceira nota: ");
        aluno.n3 = decimal.Parse(Console.ReadLine());

        Console.WriteLine($"A média harmônica ficou: {aluno.CalcularMediaArmonica()}");

        Console.WriteLine("Informe a primeira nota: ");
        aluno.nota1 = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Informe a segunda nota: ");
        aluno.nota2 = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Informe o peso da prova 1: ");
        aluno.peso1 = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Informe o peso da prova 2: ");
        aluno.peso2 = decimal.Parse(Console.ReadLine());

        Console.WriteLine($"A média final ficou: {aluno.CalcularMediaPonderada()}");
    }
}