using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício3.ConsoleApp
{
    internal class Volume
    {
        public double raio;
        public double altura;

        public double CalcularVolume()
        {
            return Math.PI * Math.Pow(raio,2) * altura;
        }
    }
}
