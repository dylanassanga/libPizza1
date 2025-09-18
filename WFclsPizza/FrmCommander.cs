﻿using System;
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
    public partial class FrmCommander : Form
    {
        public FrmCommander()
        {
            InitializeComponent();
        }//test
        private void raz()
        {
            cmbPizza.SelectedIndex = -1;
            nudPizza.Value = 0;
            lstCommClt.Items.Clear();
            lblMtPizza.Text = null;
        }
        //
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.grbClients.Controls)
            {
                if (control is TextBox)
                {
                    TextBox txt = control as TextBox;
                    txt.Text = null;
                }
                if (control is CheckBox)
                {
                    CheckBox chk = control as CheckBox;
                    chk.Checked = false;
                }
            }
            raz();
        }

        private void toolStrip_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ma première version");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            raz();
        }
    }
}
