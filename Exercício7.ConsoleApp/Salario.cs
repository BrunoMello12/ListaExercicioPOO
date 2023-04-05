using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício7.ConsoleApp
{
    internal class Salario
    {
        public decimal salarioBase;
        public decimal totalVendas;
        public decimal comissao;

        public decimal CalcularSalario()
        {
            return salarioBase + (totalVendas * (salarioBase * comissao / 100));
        }
    }
}
