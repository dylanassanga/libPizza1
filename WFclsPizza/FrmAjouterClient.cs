using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFclsPizza
{
    public partial class FrmAjouterClient : Form
    {
        public FrmAjouterClient()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            // Je récupère les données des champs
            string nom = txtNom.Text.Trim();
            string prenom = txtPrenom.Text.Trim();
            string adresse = txtAdresse.Text.Trim();
            string cp = txtCp.Text.Trim();
            string ville = txtVille.Text.Trim();
            string tel = txtTel.Text.Trim();

            //Je verifie que les champs obligatoires soient remplis
            if(string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(prenom))
            {
                MessageBox.Show("Le nom et le prénom sont obligatoires!","Attention", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            //J'attoute donc mes clients en faisant appel à la methode AjouterClient(...)

        }
    }
}
