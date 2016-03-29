namespace GestionPort
{
    partial class FrmNavire
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
            this.label1 = new System.Windows.Forms.Label();
            this.grpBoxPort = new System.Windows.Forms.GroupBox();
            this.lblNbStockages = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCreerPort = new System.Windows.Forms.Button();
            this.grpBoxStockages = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAfficherStockages = new System.Windows.Forms.Button();
            this.btnCreerStockage = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.grpBoxNavire = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxNum = new System.Windows.Forms.TextBox();
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.txtBoxFret = new System.Windows.Forms.TextBox();
            this.txtBoxQte = new System.Windows.Forms.TextBox();
            this.btnCreerNavire = new System.Windows.Forms.Button();
            this.btnNomBateau = new System.Windows.Forms.Button();
            this.labelNomBateau = new System.Windows.Forms.Label();
            this.grpBoxAction = new System.Windows.Forms.GroupBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnDecharger = new System.Windows.Forms.Button();
            this.grpBoxPort.SuspendLayout();
            this.grpBoxStockages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.grpBoxNavire.SuspendLayout();
            this.grpBoxAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(73, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Les classes et les Winforms";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpBoxPort
            // 
            this.grpBoxPort.Controls.Add(this.lblNbStockages);
            this.grpBoxPort.Controls.Add(this.label2);
            this.grpBoxPort.Controls.Add(this.BtnCreerPort);
            this.grpBoxPort.Location = new System.Drawing.Point(12, 51);
            this.grpBoxPort.Name = "grpBoxPort";
            this.grpBoxPort.Size = new System.Drawing.Size(457, 83);
            this.grpBoxPort.TabIndex = 1;
            this.grpBoxPort.TabStop = false;
            this.grpBoxPort.Text = "Port";
            // 
            // lblNbStockages
            // 
            this.lblNbStockages.AutoSize = true;
            this.lblNbStockages.Location = new System.Drawing.Point(265, 43);
            this.lblNbStockages.Name = "lblNbStockages";
            this.lblNbStockages.Size = new System.Drawing.Size(0, 13);
            this.lblNbStockages.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NbStockages :";
            // 
            // BtnCreerPort
            // 
            this.BtnCreerPort.Location = new System.Drawing.Point(15, 38);
            this.BtnCreerPort.Name = "BtnCreerPort";
            this.BtnCreerPort.Size = new System.Drawing.Size(98, 23);
            this.BtnCreerPort.TabIndex = 0;
            this.BtnCreerPort.Text = "Creer un Port";
            this.BtnCreerPort.UseVisualStyleBackColor = true;
            // 
            // grpBoxStockages
            // 
            this.grpBoxStockages.Controls.Add(this.comboBox1);
            this.grpBoxStockages.Controls.Add(this.btnAfficherStockages);
            this.grpBoxStockages.Controls.Add(this.btnCreerStockage);
            this.grpBoxStockages.Controls.Add(this.numericUpDown1);
            this.grpBoxStockages.Controls.Add(this.label3);
            this.grpBoxStockages.Location = new System.Drawing.Point(12, 153);
            this.grpBoxStockages.Name = "grpBoxStockages";
            this.grpBoxStockages.Size = new System.Drawing.Size(457, 121);
            this.grpBoxStockages.TabIndex = 2;
            this.grpBoxStockages.TabStop = false;
            this.grpBoxStockages.Text = "Stockages";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(169, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // btnAfficherStockages
            // 
            this.btnAfficherStockages.Location = new System.Drawing.Point(18, 54);
            this.btnAfficherStockages.Name = "btnAfficherStockages";
            this.btnAfficherStockages.Size = new System.Drawing.Size(110, 23);
            this.btnAfficherStockages.TabIndex = 3;
            this.btnAfficherStockages.Text = "button1";
            this.btnAfficherStockages.UseVisualStyleBackColor = true;
            // 
            // btnCreerStockage
            // 
            this.btnCreerStockage.Location = new System.Drawing.Point(169, 17);
            this.btnCreerStockage.Name = "btnCreerStockage";
            this.btnCreerStockage.Size = new System.Drawing.Size(144, 23);
            this.btnCreerStockage.TabIndex = 2;
            this.btnCreerStockage.Text = "Creer un Stockage";
            this.btnCreerStockage.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(77, 20);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Capacité :";
            // 
            // grpBoxNavire
            // 
            this.grpBoxNavire.Controls.Add(this.labelNomBateau);
            this.grpBoxNavire.Controls.Add(this.btnNomBateau);
            this.grpBoxNavire.Controls.Add(this.btnCreerNavire);
            this.grpBoxNavire.Controls.Add(this.txtBoxQte);
            this.grpBoxNavire.Controls.Add(this.txtBoxFret);
            this.grpBoxNavire.Controls.Add(this.txtBoxNom);
            this.grpBoxNavire.Controls.Add(this.txtBoxNum);
            this.grpBoxNavire.Controls.Add(this.label7);
            this.grpBoxNavire.Controls.Add(this.label6);
            this.grpBoxNavire.Controls.Add(this.label5);
            this.grpBoxNavire.Controls.Add(this.label4);
            this.grpBoxNavire.Location = new System.Drawing.Point(13, 287);
            this.grpBoxNavire.Name = "grpBoxNavire";
            this.grpBoxNavire.Size = new System.Drawing.Size(455, 205);
            this.grpBoxNavire.TabIndex = 3;
            this.grpBoxNavire.TabStop = false;
            this.grpBoxNavire.Text = "Navire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Quantité :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Frêt :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nom :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Numéro :";
            // 
            // txtBoxNum
            // 
            this.txtBoxNum.Location = new System.Drawing.Point(115, 29);
            this.txtBoxNum.Name = "txtBoxNum";
            this.txtBoxNum.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNum.TabIndex = 5;
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.Location = new System.Drawing.Point(115, 55);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNom.TabIndex = 6;
            // 
            // txtBoxFret
            // 
            this.txtBoxFret.Location = new System.Drawing.Point(115, 81);
            this.txtBoxFret.Name = "txtBoxFret";
            this.txtBoxFret.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFret.TabIndex = 7;
            // 
            // txtBoxQte
            // 
            this.txtBoxQte.Location = new System.Drawing.Point(115, 108);
            this.txtBoxQte.Name = "txtBoxQte";
            this.txtBoxQte.Size = new System.Drawing.Size(100, 20);
            this.txtBoxQte.TabIndex = 8;
            // 
            // btnCreerNavire
            // 
            this.btnCreerNavire.Location = new System.Drawing.Point(267, 29);
            this.btnCreerNavire.Name = "btnCreerNavire";
            this.btnCreerNavire.Size = new System.Drawing.Size(143, 31);
            this.btnCreerNavire.TabIndex = 9;
            this.btnCreerNavire.Text = "Créer un Navire";
            this.btnCreerNavire.UseVisualStyleBackColor = true;
            // 
            // btnNomBateau
            // 
            this.btnNomBateau.Location = new System.Drawing.Point(267, 90);
            this.btnNomBateau.Name = "btnNomBateau";
            this.btnNomBateau.Size = new System.Drawing.Size(143, 31);
            this.btnNomBateau.TabIndex = 10;
            this.btnNomBateau.Text = "Voir Nom du Bateau";
            this.btnNomBateau.UseVisualStyleBackColor = true;
            // 
            // labelNomBateau
            // 
            this.labelNomBateau.AutoSize = true;
            this.labelNomBateau.Location = new System.Drawing.Point(278, 139);
            this.labelNomBateau.Name = "labelNomBateau";
            this.labelNomBateau.Size = new System.Drawing.Size(0, 13);
            this.labelNomBateau.TabIndex = 11;
            // 
            // grpBoxAction
            // 
            this.grpBoxAction.Controls.Add(this.btnDecharger);
            this.grpBoxAction.Controls.Add(this.btnQuitter);
            this.grpBoxAction.Location = new System.Drawing.Point(12, 499);
            this.grpBoxAction.Name = "grpBoxAction";
            this.grpBoxAction.Size = new System.Drawing.Size(456, 100);
            this.grpBoxAction.TabIndex = 4;
            this.grpBoxAction.TabStop = false;
            this.grpBoxAction.Text = "Action";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(198, 35);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(143, 31);
            this.btnQuitter.TabIndex = 10;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // btnDecharger
            // 
            this.btnDecharger.Location = new System.Drawing.Point(18, 35);
            this.btnDecharger.Name = "btnDecharger";
            this.btnDecharger.Size = new System.Drawing.Size(143, 31);
            this.btnDecharger.TabIndex = 11;
            this.btnDecharger.Text = "Décharger";
            this.btnDecharger.UseVisualStyleBackColor = true;
            // 
            // FrmNavire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 614);
            this.Controls.Add(this.grpBoxAction);
            this.Controls.Add(this.grpBoxNavire);
            this.Controls.Add(this.grpBoxStockages);
            this.Controls.Add(this.grpBoxPort);
            this.Controls.Add(this.label1);
            this.Name = "FrmNavire";
            this.Text = "Z";
            this.Load += new System.EventHandler(this.FrmNavire_Load);
            this.grpBoxPort.ResumeLayout(false);
            this.grpBoxPort.PerformLayout();
            this.grpBoxStockages.ResumeLayout(false);
            this.grpBoxStockages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.grpBoxNavire.ResumeLayout(false);
            this.grpBoxNavire.PerformLayout();
            this.grpBoxAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBoxPort;
        private System.Windows.Forms.Label lblNbStockages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCreerPort;
        private System.Windows.Forms.GroupBox grpBoxStockages;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAfficherStockages;
        private System.Windows.Forms.Button btnCreerStockage;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox grpBoxNavire;
        private System.Windows.Forms.Label labelNomBateau;
        private System.Windows.Forms.Button btnNomBateau;
        private System.Windows.Forms.Button btnCreerNavire;
        private System.Windows.Forms.TextBox txtBoxQte;
        private System.Windows.Forms.TextBox txtBoxFret;
        private System.Windows.Forms.TextBox txtBoxNom;
        private System.Windows.Forms.TextBox txtBoxNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpBoxAction;
        private System.Windows.Forms.Button btnDecharger;
        private System.Windows.Forms.Button btnQuitter;
    }
}