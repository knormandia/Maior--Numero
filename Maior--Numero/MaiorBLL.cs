using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maior__Numero
{
    class MaiorBLL // Validação dos dados colocados na textbox
    {
        public static void ValidaDados(Num umNumero)
        {
            Erro.AcheiErro = false;

            try
            {
                int.Parse(umNumero.Numero01);
                int.Parse(umNumero.Numero02);
                int.Parse(umNumero.Numero03);

            }
            catch
            {
                Erro.Mensagem = "O campo só aceita valores numéricos!";
                return;
            }




        }
    }
}
