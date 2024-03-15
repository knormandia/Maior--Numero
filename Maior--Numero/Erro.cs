using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maior__Numero
{
    
    class Erro // Mensagem de erro
    {
        public static bool AcheiErro { get; set; }

        private static string mensagemValor;
        public static string Mensagem
        {
            get { return mensagemValor; }
            set { AcheiErro = true; mensagemValor = value; }
        }
    }
}

