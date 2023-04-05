using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9_10.ConsoleApp
{
    internal class Aluno
    {
        public decimal n1;
        public decimal n2;
        public decimal n3;
        public decimal nota1;
        public decimal nota2;
        public decimal peso1;
        public decimal peso2;

        public decimal CalcularMediaArmonica()
        {
            return 3 / (1 / n1 + 1 / n2 + 1 / n3);
        }

        public decimal CalcularMediaPonderada()
        {
           return (nota1 * peso1) + (nota2 * peso2) / (peso1 + peso2);
        }
    }
}
