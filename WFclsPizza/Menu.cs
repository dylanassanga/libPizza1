namespace WFclsPizza
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCommander formAjouter = new FrmCommander();
            formAjouter.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmAjouterPizza formAjouter = new FrmAjouterPizza();
            formAjouter.Show();

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmAjouterClient formAjouter = new FrmAjouterClient();
            formAjouter.Show();
        }
    }
}
