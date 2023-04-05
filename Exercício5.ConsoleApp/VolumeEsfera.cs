using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício5.ConsoleApp
{
    internal class VolumeEsfera
    {
        public double raio;

        public double CalcularVolume()
        {
            return 4 / 3 * Math.Pow(raio,3) * Math.PI;
        }
    }
}
