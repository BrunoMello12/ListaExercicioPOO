using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício8.ConsoleApp
{
    internal class LataOleo
    {
        public double raio;
        public double altura;

        public double CalcularVolume()
        {
            return Math.Pow(raio,3) * Math.PI * altura;
        }
    }
}
