using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício6.ConsoleApp
{
    internal class ConverterTemperatura
    {
        public decimal celsius;

        public decimal ConverterCelsius()
        {
            return celsius * 9 / 5 +32;
        }
    }
}
