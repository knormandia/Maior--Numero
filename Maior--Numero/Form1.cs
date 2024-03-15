using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace Maior__Numero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMaior_Click(object sender, EventArgs e)
        {
            int maior;

            var umNumero = new Num();
            umNumero.Numero01 = txtVal01.Text;
            umNumero.Numero02 = txtVal02.Text;
            umNumero.Numero03 = txtVal03.Text;

            int[] numeros = umNumero.ConverteNum(); // lista dos números convertidos

            MaiorBLL.ValidaDados(umNumero);
            if (Erro.AcheiErro)
            {
                MessageBox.Show(Erro.Mensagem);
            }
            else
            {
                if (numeros[0] > numeros[1] && numeros[0] > numeros[2])
                {
                    maior = numeros[0];
                    lbResultado.Text = ("O maior é: " + maior);
                }
                else if (numeros[1] > numeros[2])
                {
                    maior = numeros[1];
                    lbResultado.Text = ("O maior é: " + maior);
                }
                else
                {
                    maior = numeros[2];
                    lbResultado.Text = ("O maior é: " + maior);
                }
            }
        }
    }
}
