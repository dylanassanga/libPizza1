﻿namespace WFclsPizza
{
    partial class FrmAjouterPizza
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
            label1 = new Label();
            label2 = new Label();
            txtNomPizza = new TextBox();
            txtPrix = new TextBox();
            button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 69);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 0;
            label1.Text = "Nom de la Pizza";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(374, 69);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 1;
            label2.Text = "Prix";
            // 
            // txtNomPizza
            // 
            txtNomPizza.Location = new Point(54, 121);
            txtNomPizza.Name = "txtNomPizza";
            txtNomPizza.Size = new Size(125, 27);
            txtNomPizza.TabIndex = 2;
            // 
            // txtPrix
            // 
            txtPrix.Location = new Point(374, 121);
            txtPrix.Name = "txtPrix";
            txtPrix.Size = new Size(125, 27);
            txtPrix.TabIndex = 3;
            // 
            // button
            // 
            button.Location = new Point(251, 229);
            button.Name = "button";
            button.Size = new Size(94, 29);
            button.TabIndex = 4;
            button.Text = "Valider";
            button.UseVisualStyleBackColor = true;
            // 
            // FrmAjouterPizza
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button);
            Controls.Add(txtPrix);
            Controls.Add(txtNomPizza);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAjouterPizza";
            Text = "AjouterPizza";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNomPizza;
        private TextBox txtPrix;
        private Button button;
    }
}