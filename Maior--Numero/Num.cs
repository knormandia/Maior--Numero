using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maior__Numero
{
    class Num // Conversão dos números colocados (a textbox retorna string)
    {
        public string Numero01 { get; set; }
        public string Numero02 { get; set; }
        public string Numero03 { get; set; }

        public int[] ConverteNum()
        {
            int[] numeros = new int[3];

            int.TryParse(Numero01, out numeros[0]);
            int.TryParse(Numero02, out numeros[1]);
            int.TryParse(Numero03, out numeros[2]);

            return numeros;
        }
    }
}
