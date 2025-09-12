namespace wfpizza
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAjouterClient fm = new FrmAjouterClient();
            fm.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmAjouterClient fm = new FrmAjouterClient();
            fm.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //FrmCommander fm = new FrmAjouterPizza();
            //fm.Show();
        }
    }
}
