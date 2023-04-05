using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício4.ConsoleApp
{
    internal class ConsumoMedio
    {
        public decimal kmI;
        public decimal kmF;
        public decimal gasolina;

        public decimal CalcularConsumo()
        {
            return gasolina / (kmF - kmI);
        }
    }
}
