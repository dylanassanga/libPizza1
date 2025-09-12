namespace wfpizza
{
    partial class FrmAjouterClient
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
            button = new Button();
            txtNom = new TextBox();
            txtTel = new TextBox();
            txtVille = new TextBox();
            txtCp = new TextBox();
            txtAdresse = new TextBox();
            txtPrenom = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button
            // 
            button.Location = new Point(329, 302);
            button.Name = "button";
            button.Size = new Size(94, 29);
            button.TabIndex = 0;
            button.Text = "Valider";
            button.UseVisualStyleBackColor = true;
           
            // 
            // txtNom
            // 
            txtNom.Location = new Point(308, 12);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(125, 27);
            txtNom.TabIndex = 1;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(308, 218);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(125, 27);
            txtTel.TabIndex = 4;
            // 
            // txtVille
            // 
            txtVille.Location = new Point(308, 180);
            txtVille.Name = "txtVille";
            txtVille.Size = new Size(125, 27);
            txtVille.TabIndex = 5;
            // 
            // txtCp
            // 
            txtCp.Location = new Point(308, 140);
            txtCp.Name = "txtCp";
            txtCp.Size = new Size(125, 27);
            txtCp.TabIndex = 6;
            // 
            // txtAdresse
            // 
            txtAdresse.Location = new Point(308, 102);
            txtAdresse.Name = "txtAdresse";
            txtAdresse.Size = new Size(125, 27);
            txtAdresse.TabIndex = 7;
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(308, 55);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(125, 27);
            txtPrenom.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 19);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 9;
            label1.Text = "Nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 183);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 10;
            label2.Text = "Ville";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(168, 140);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 11;
            label3.Text = "Code Postal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(168, 102);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 12;
            label4.Text = "Adresse";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(168, 225);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 13;
            label5.Text = "Télèphone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(168, 62);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 14;
            label6.Text = "Prénom";
            // 
            // FrmAjouterClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPrenom);
            Controls.Add(txtAdresse);
            Controls.Add(txtCp);
            Controls.Add(txtVille);
            Controls.Add(txtTel);
            Controls.Add(txtNom);
            Controls.Add(button);
            Name = "FrmAjouterClient";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button;
        private TextBox txtNom;
        private TextBox txtTel;
        private TextBox txtVille;
        private TextBox txtCp;
        private TextBox txtAdresse;
        private TextBox txtPrenom;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}