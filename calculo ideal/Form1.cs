using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculo_ideal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmd_calcular.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void text_altura_TextChanged(object sender, EventArgs e)
        {
            cmd_calcular.Enabled = text_altura.Text != "" ? true : false;

        }

        private void cmd_calcular_Click(object sender, EventArgs e)
        {
            double.TryParse(text_altura.Text, out double altura);
            if (altura == null) return;

            //executar os calculos
            double peso_ideal = 0;

            //condição homem ou mulher
            if (radio_homem.Checked)
            {
                //homem
                peso_ideal = (72.7 * altura) - 58;
            }
            else
            {
                //mulher
                peso_ideal = (61.7 * altura) - 44.7;
            }
            StringBuilder str = new StringBuilder("peso ideal: " + peso_ideal.ToString("0.00") + "kg.");

            //comparação com o peso atual
            if (text_peso_atual.Text != "")
            {
                double.TryParse(text_peso_atual.Text, out double peso_atual);
                if (peso_atual != null)
                {
                    if (peso_ideal < peso_atual)
                    {
                        //deve emagrecer
                        str.Append(Environment.NewLine + "Deve emagrecer" + (peso_atual - peso_ideal).ToString("0.00") + "Kg.");
                    }
                    else if (peso_ideal > peso_atual)
                    {
                        //esta abaixo do seu peso ideal
                        str.Append(Environment.NewLine + "Está" + (peso_ideal - peso_atual).ToString("0.00") + "Kg. abaixo do seu peso ideal.");
                    }
                    else
                    {
                        str.Append(Environment.NewLine + "Parabéns! Está com o seu peso ideal.");
                    }
                }
            }
            MessageBox.Show(str.ToString());
        }
    }
}
