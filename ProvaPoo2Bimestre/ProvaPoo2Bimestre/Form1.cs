namespace ProvaPoo2Bimestre
{
    public partial class bt_correcao : Form
    {
        public bt_correcao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProvaGabarito prova = new ProvaGabarito();

            prova.ShowDialog();
        }
    }
}