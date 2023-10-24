using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaPoo2Bimestre
{
    public partial class ProvaGabarito : Form
    {
        public ProvaGabarito()
        {
            InitializeComponent();
            lb_resultado.Text = "";
        }

        private void bt_avaliar_Click(object sender, EventArgs e)
        {
            string[] array = { "A", "B", "D", "E", "C", "A", "A", "D", "E", "B" };

            string[] respostas = {tx_quest1.Text, tx_quest2.Text, tx_quest3.Text, tx_quest4.Text, tx_quest5.Text, tx_quest6.Text, tx_quest7.Text, tx_quest8.Text, tx_quest9.Text, tx_quest10.Text};

            int contadoracertos = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == respostas[i].ToUpper())
                {
                    contadoracertos++;
                }
            }

            lb_resultado.Text = $"{contadoracertos.ToString()}/10";
        }
    }
}
