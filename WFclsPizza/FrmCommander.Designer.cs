namespace WFclsPizza
{
    partial class FrmCommander
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCommander));
            grbClients = new GroupBox();
            chkEmporter = new CheckBox();
            cmbNom = new ComboBox();
            txtVille = new TextBox();
            txtPrenom = new TextBox();
            txtTel = new TextBox();
            txtCp = new TextBox();
            txtAdresse = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grbCommande = new GroupBox();
            btnAjouter = new Button();
            nudPizza = new NumericUpDown();
            label8 = new Label();
            label7 = new Label();
            cmbPizza = new ComboBox();
            lstCommClt = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnEffacer = new Button();
            btnCommander = new Button();
            lblMtPizza = new Label();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStrip = new ToolStripButton();
            grbClients.SuspendLayout();
            grbCommande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPizza).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // grbClients
            // 
            grbClients.Controls.Add(chkEmporter);
            grbClients.Controls.Add(cmbNom);
            grbClients.Controls.Add(txtVille);
            grbClients.Controls.Add(txtPrenom);
            grbClients.Controls.Add(txtTel);
            grbClients.Controls.Add(txtCp);
            grbClients.Controls.Add(txtAdresse);
            grbClients.Controls.Add(label6);
            grbClients.Controls.Add(label5);
            grbClients.Controls.Add(label4);
            grbClients.Controls.Add(label3);
            grbClients.Controls.Add(label2);
            grbClients.Controls.Add(label1);
            grbClients.Location = new Point(335, 33);
            grbClients.Name = "grbClients";
            grbClients.Size = new Size(560, 170);
            grbClients.TabIndex = 0;
            grbClients.TabStop = false;
            grbClients.Text = "Client";
            // 
            // chkEmporter
            // 
            chkEmporter.AutoSize = true;
            chkEmporter.Location = new Point(55, 141);
            chkEmporter.Name = "chkEmporter";
            chkEmporter.Size = new Size(107, 24);
            chkEmporter.TabIndex = 12;
            chkEmporter.Text = "A emporter";
            chkEmporter.UseVisualStyleBackColor = true;
            // 
            // cmbNom
            // 
            cmbNom.FormattingEnabled = true;
            cmbNom.Location = new Point(124, 20);
            cmbNom.Name = "cmbNom";
            cmbNom.Size = new Size(134, 28);
            cmbNom.TabIndex = 11;
            // 
            // txtVille
            // 
            txtVille.Location = new Point(400, 107);
            txtVille.Name = "txtVille";
            txtVille.Size = new Size(125, 27);
            txtVille.TabIndex = 10;
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(124, 60);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(125, 27);
            txtPrenom.TabIndex = 9;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(124, 100);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(125, 27);
            txtTel.TabIndex = 8;
            // 
            // txtCp
            // 
            txtCp.Location = new Point(400, 67);
            txtCp.Name = "txtCp";
            txtCp.Size = new Size(125, 27);
            txtCp.TabIndex = 7;
            // 
            // txtAdresse
            // 
            txtAdresse.Location = new Point(400, 25);
            txtAdresse.Name = "txtAdresse";
            txtAdresse.Size = new Size(125, 27);
            txtAdresse.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 107);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 5;
            label6.Text = "Télèphone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 67);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 4;
            label5.Text = "Prenom";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(307, 28);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 3;
            label4.Text = "Adresse";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(307, 67);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 2;
            label3.Text = "Code Postal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 107);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 1;
            label2.Text = "Ville";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 28);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "Nom";
            // 
            // grbCommande
            // 
            grbCommande.Controls.Add(btnAjouter);
            grbCommande.Controls.Add(nudPizza);
            grbCommande.Controls.Add(label8);
            grbCommande.Controls.Add(label7);
            grbCommande.Controls.Add(cmbPizza);
            grbCommande.Location = new Point(335, 243);
            grbCommande.Name = "grbCommande";
            grbCommande.Size = new Size(561, 193);
            grbCommande.TabIndex = 1;
            grbCommande.TabStop = false;
            grbCommande.Text = "groupBox2";
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(274, 147);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(94, 29);
            btnAjouter.TabIndex = 4;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            // 
            // nudPizza
            // 
            nudPizza.Location = new Point(462, 77);
            nudPizza.Name = "nudPizza";
            nudPizza.Size = new Size(53, 27);
            nudPizza.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(449, 54);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 2;
            label8.Text = "Quantité";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 43);
            label7.Name = "label7";
            label7.Size = new Size(43, 20);
            label7.TabIndex = 1;
            label7.Text = "Pizza";
            // 
            // cmbPizza
            // 
            cmbPizza.FormattingEnabled = true;
            cmbPizza.Location = new Point(40, 83);
            cmbPizza.Name = "cmbPizza";
            cmbPizza.Size = new Size(137, 28);
            cmbPizza.TabIndex = 0;
            // 
            // lstCommClt
            // 
            lstCommClt.FormattingEnabled = true;
            lstCommClt.Location = new Point(25, 50);
            lstCommClt.Name = "lstCommClt";
            lstCommClt.Size = new Size(173, 304);
            lstCommClt.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnEffacer
            // 
            btnEffacer.Location = new Point(56, 407);
            btnEffacer.Name = "btnEffacer";
            btnEffacer.Size = new Size(94, 29);
            btnEffacer.TabIndex = 5;
            btnEffacer.Text = "Effacer";
            btnEffacer.UseVisualStyleBackColor = true;
            // 
            // btnCommander
            // 
            btnCommander.Location = new Point(336, 442);
            btnCommander.Name = "btnCommander";
            btnCommander.Size = new Size(560, 77);
            btnCommander.TabIndex = 6;
            btnCommander.Text = "Commander";
            btnCommander.UseVisualStyleBackColor = true;
            // 
            // lblMtPizza
            // 
            lblMtPizza.AutoSize = true;
            lblMtPizza.Location = new Point(84, 374);
            lblMtPizza.Name = "lblMtPizza";
            lblMtPizza.Size = new Size(17, 20);
            lblMtPizza.TabIndex = 7;
            lblMtPizza.Text = "0";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStrip });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(907, 27);
            toolStrip1.TabIndex = 8;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 24);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 24);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStrip
            // 
            toolStrip.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStrip.Image = (Image)resources.GetObject("toolStrip.Image");
            toolStrip.ImageTransparentColor = Color.Magenta;
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(29, 24);
            toolStrip.Text = "toolStripButton3";
            toolStrip.Click += toolStrip_Click;
            // 
            // FrmCommander
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 530);
            Controls.Add(toolStrip1);
            Controls.Add(lblMtPizza);
            Controls.Add(btnCommander);
            Controls.Add(btnEffacer);
            Controls.Add(lstCommClt);
            Controls.Add(grbCommande);
            Controls.Add(grbClients);
            Name = "FrmCommander";
            Text = "Commander";
            grbClients.ResumeLayout(false);
            grbClients.PerformLayout();
            grbCommande.ResumeLayout(false);
            grbCommande.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPizza).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbClients;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox grbCommande;
        private ListBox lstCommClt;
        private ComboBox cmbNom;
        private TextBox txtVille;
        private TextBox txtPrenom;
        private TextBox txtTel;
        private TextBox txtCp;
        private TextBox txtAdresse;
        private CheckBox chkEmporter;
        private ContextMenuStrip contextMenuStrip1;
        private Label label7;
        private ComboBox cmbPizza;
        private Button btnAjouter;
        private NumericUpDown nudPizza;
        private Label label8;
        private Button btnEffacer;
        private Button btnCommander;
        private Label lblMtPizza;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStrip;
    }
}