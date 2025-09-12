namespace wfpizza
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /*protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }*/

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            label1 = new Label();
            label11 = new Label();
            label3 = new Label();
            Pizza = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtVille = new TextBox();
            txtCp = new TextBox();
            txtAdresse = new TextBox();
            txtTel = new TextBox();
            btnAjouter = new Button();
            txtPrenom = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new GroupBox();
            cmbNom = new ComboBox();
            grbCommande = new GroupBox();
            cmbPizza = new ComboBox();
            nudPizza = new NumericUpDown();
            btnCommander = new Button();
            btnEffacer = new Button();
            lblMtPizza = new Label();
            lstCommClt = new ListBox();
            chkEmporter = new CheckBox();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStrip1 = new ToolStrip();
            groupBox1.SuspendLayout();
            grbCommande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPizza).BeginInit();
            toolStrip1.SuspendLayout();
            //SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 33);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 1;
            label1.Text = "Nom";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(33, 68);
            label11.Name = "label11";
            label11.Size = new Size(60, 20);
            label11.TabIndex = 10;
            label11.Text = "Prénom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(461, 23);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 11;
            label3.Text = "Quantité";
            // 
            // Pizza
            // 
            Pizza.AutoSize = true;
            Pizza.Location = new Point(58, 23);
            Pizza.Name = "Pizza";
            Pizza.Size = new Size(43, 20);
            Pizza.TabIndex = 12;
            Pizza.Text = "Pizza";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(354, 120);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 14;
            label6.Text = "Ville";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(348, 72);
            label7.Name = "label7";
            label7.Size = new Size(87, 20);
            label7.TabIndex = 15;
            label7.Text = "Code Postal";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(354, 33);
            label8.Name = "label8";
            label8.Size = new Size(61, 20);
            label8.TabIndex = 16;
            label8.Text = "Adresse";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(33, 116);
            label9.Name = "label9";
            label9.Size = new Size(78, 20);
            label9.TabIndex = 17;
            label9.Text = "Téléphone";
            // 
            // txtVille
            // 
            txtVille.BackColor = Color.WhiteSmoke;
            txtVille.Location = new Point(441, 113);
            txtVille.Name = "txtVille";
            txtVille.Size = new Size(125, 27);
            txtVille.TabIndex = 23;
            // 
            // txtCp
            // 
            txtCp.BackColor = Color.WhiteSmoke;
            txtCp.Location = new Point(441, 68);
            txtCp.Name = "txtCp";
            txtCp.Size = new Size(125, 27);
            txtCp.TabIndex = 24;
            // 
            // txtAdresse
            // 
            txtAdresse.BackColor = Color.WhiteSmoke;
            txtAdresse.Location = new Point(441, 26);
            txtAdresse.Name = "txtAdresse";
            txtAdresse.Size = new Size(125, 27);
            txtAdresse.TabIndex = 25;
            // 
            // txtTel
            // 
            txtTel.BackColor = Color.WhiteSmoke;
            txtTel.Location = new Point(141, 116);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(125, 27);
            txtTel.TabIndex = 26;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(258, 86);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(94, 29);
            btnAjouter.TabIndex = 27;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            // 
            // txtPrenom
            // 
            txtPrenom.BackColor = Color.WhiteSmoke;
            txtPrenom.Location = new Point(141, 65);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(125, 27);
            txtPrenom.TabIndex = 28;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkEmporter);
            groupBox1.Controls.Add(cmbNom);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtPrenom);
            groupBox1.Controls.Add(txtVille);
            groupBox1.Controls.Add(txtCp);
            groupBox1.Controls.Add(txtAdresse);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtTel);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label9);
            groupBox1.Location = new Point(242, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(586, 183);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Client";
            // 
            // cmbNom
            // 
            cmbNom.FormattingEnabled = true;
            cmbNom.Location = new Point(115, 25);
            cmbNom.Name = "cmbNom";
            cmbNom.Size = new Size(151, 28);
            cmbNom.TabIndex = 30;
            // 
            // grbCommande
            // 
            grbCommande.Controls.Add(nudPizza);
            grbCommande.Controls.Add(cmbPizza);
            grbCommande.Controls.Add(Pizza);
            grbCommande.Controls.Add(btnAjouter);
            grbCommande.Controls.Add(label3);
            grbCommande.Location = new Point(242, 257);
            grbCommande.Name = "grbCommande";
            grbCommande.Size = new Size(586, 168);
            grbCommande.TabIndex = 30;
            grbCommande.TabStop = false;
            grbCommande.Text = "Commande";
            // 
            // cmbPizza
            // 
            cmbPizza.FormattingEnabled = true;
            cmbPizza.Location = new Point(32, 56);
            cmbPizza.Name = "cmbPizza";
            cmbPizza.Size = new Size(151, 28);
            cmbPizza.TabIndex = 28;
            // 
            // nudPizza
            // 
            nudPizza.Location = new Point(470, 57);
            nudPizza.Name = "nudPizza";
            nudPizza.Size = new Size(57, 27);
            nudPizza.TabIndex = 29;
            // 
            // btnCommander
            // 
            btnCommander.Location = new Point(241, 451);
            btnCommander.Name = "btnCommander";
            btnCommander.Size = new Size(587, 82);
            btnCommander.TabIndex = 30;
            btnCommander.Text = "Commander";
            btnCommander.UseVisualStyleBackColor = true;
            // 
            // btnEffacer
            // 
            btnEffacer.Location = new Point(46, 493);
            btnEffacer.Name = "btnEffacer";
            btnEffacer.Size = new Size(94, 29);
            btnEffacer.TabIndex = 31;
            btnEffacer.Text = "Effacer";
            btnEffacer.UseVisualStyleBackColor = true;
            // 
            // lblMtPizza
            // 
            lblMtPizza.AutoSize = true;
            lblMtPizza.Location = new Point(84, 451);
            lblMtPizza.Name = "lblMtPizza";
            lblMtPizza.Size = new Size(17, 20);
            lblMtPizza.TabIndex = 32;
            lblMtPizza.Text = "0";
            // 
            // lstCommClt
            // 
            lstCommClt.FormattingEnabled = true;
            lstCommClt.Location = new Point(12, 41);
            lstCommClt.Name = "lstCommClt";
            lstCommClt.Size = new Size(170, 384);
            lstCommClt.TabIndex = 33;
            // 
            // chkEmporter
            // 
            chkEmporter.AutoSize = true;
            chkEmporter.Location = new Point(43, 153);
            chkEmporter.Name = "chkEmporter";
            chkEmporter.Size = new Size(107, 24);
            chkEmporter.TabIndex = 31;
            chkEmporter.Text = "A emporter";
            chkEmporter.UseVisualStyleBackColor = true;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 24);
            toolStripButton1.Text = "toolStripButtonNew";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 24);
            toolStripButton2.Text = "toolStripButtonSupprimer";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(29, 24);
            toolStripButton3.Text = "toolStripButtonAide";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(855, 27);
            toolStrip1.TabIndex = 34;
            toolStrip1.Text = "toolStrip1";
            // 
            // Form4
            // 
           
           
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grbCommande.ResumeLayout(false);
            grbCommande.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPizza).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
           
        }

        #endregion

        private Label label1;
        private Label label11;
        private Label label3;
        private Label Pizza;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox txtVille;
        private TextBox txtCp;
        private TextBox txtAdresse;
        private TextBox txtTel;
        private Button btnAjouter;
        private TextBox txtPrenom;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private ComboBox cmbNom;
        private GroupBox grbCommande;
        private ComboBox cmbPizza;
        private NumericUpDown nudPizza;
        private Button btnCommander;
        private Button btnEffacer;
        private Label lblMtPizza;
        private ListBox lstCommClt;
        private CheckBox chkEmporter;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStrip toolStrip1;
    }
}