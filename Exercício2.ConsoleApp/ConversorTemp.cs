using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício2.ConsoleApp
{
    internal class ConversorTemp
    {
        public decimal temp;

        public decimal temperaturaFinal()
        {
            return (temp - 32) * 5 / 9;
        }
    }
}
