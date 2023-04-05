using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercícioPOO.ConsoleApp
{
   

    internal class Caixa
    {
        public int altura;
        public int largura;
        public int comprimento;

        public int CalcularVolume()
        {
            return altura*largura*comprimento;
        }
    }
}
