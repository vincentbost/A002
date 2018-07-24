namespace A002
{
    partial class FrmDamier
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlDamier = new System.Windows.Forms.Panel();
            this.gBDamier = new System.Windows.Forms.GroupBox();
            this.btnImpaire = new System.Windows.Forms.Button();
            this.btnPaire = new System.Windows.Forms.Button();
            this.nLargeur = new System.Windows.Forms.NumericUpDown();
            this.nColonnes = new System.Windows.Forms.NumericUpDown();
            this.nLignes = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDamier = new System.Windows.Forms.Button();
            this.gBDamier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nLargeur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nColonnes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLignes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDamier
            // 
            this.pnlDamier.Location = new System.Drawing.Point(23, 30);
            this.pnlDamier.Name = "pnlDamier";
            this.pnlDamier.Size = new System.Drawing.Size(530, 415);
            this.pnlDamier.TabIndex = 0;
            // 
            // gBDamier
            // 
            this.gBDamier.Controls.Add(this.btnImpaire);
            this.gBDamier.Controls.Add(this.btnPaire);
            this.gBDamier.Controls.Add(this.nLargeur);
            this.gBDamier.Controls.Add(this.nColonnes);
            this.gBDamier.Controls.Add(this.nLignes);
            this.gBDamier.Controls.Add(this.label5);
            this.gBDamier.Controls.Add(this.label1);
            this.gBDamier.Controls.Add(this.label4);
            this.gBDamier.Controls.Add(this.label3);
            this.gBDamier.Controls.Add(this.label2);
            this.gBDamier.Location = new System.Drawing.Point(708, 30);
            this.gBDamier.Name = "gBDamier";
            this.gBDamier.Size = new System.Drawing.Size(328, 221);
            this.gBDamier.TabIndex = 0;
            this.gBDamier.TabStop = false;
            this.gBDamier.Text = "Caractéristiques du damier";
            // 
            // btnImpaire
            // 
            this.btnImpaire.BackColor = System.Drawing.Color.Yellow;
            this.btnImpaire.Location = new System.Drawing.Point(164, 175);
            this.btnImpaire.Name = "btnImpaire";
            this.btnImpaire.Size = new System.Drawing.Size(121, 29);
            this.btnImpaire.TabIndex = 9;
            this.btnImpaire.Text = "Modifier";
            this.btnImpaire.UseVisualStyleBackColor = false;
            this.btnImpaire.Click += new System.EventHandler(this.ChangerCouleur);
            // 
            // btnPaire
            // 
            this.btnPaire.BackColor = System.Drawing.Color.Red;
            this.btnPaire.Location = new System.Drawing.Point(164, 134);
            this.btnPaire.Name = "btnPaire";
            this.btnPaire.Size = new System.Drawing.Size(121, 29);
            this.btnPaire.TabIndex = 7;
            this.btnPaire.Text = "Modifier";
            this.btnPaire.UseVisualStyleBackColor = false;
            this.btnPaire.Click += new System.EventHandler(this.ChangerCouleur);
            // 
            // nLargeur
            // 
            this.nLargeur.Location = new System.Drawing.Point(165, 99);
            this.nLargeur.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nLargeur.Name = "nLargeur";
            this.nLargeur.Size = new System.Drawing.Size(120, 22);
            this.nLargeur.TabIndex = 5;
            this.nLargeur.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nColonnes
            // 
            this.nColonnes.Location = new System.Drawing.Point(165, 63);
            this.nColonnes.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nColonnes.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nColonnes.Name = "nColonnes";
            this.nColonnes.Size = new System.Drawing.Size(120, 22);
            this.nColonnes.TabIndex = 3;
            this.nColonnes.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nLignes
            // 
            this.nLignes.Location = new System.Drawing.Point(165, 33);
            this.nLignes.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nLignes.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nLignes.Name = "nLignes";
            this.nLignes.Size = new System.Drawing.Size(120, 22);
            this.nLignes.TabIndex = 2;
            this.nLignes.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Couleur case impaire";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Couleur case paire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Largeur en pixels";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre de colonnes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de lignes";
            // 
            // btnDamier
            // 
            this.btnDamier.Location = new System.Drawing.Point(708, 277);
            this.btnDamier.Name = "btnDamier";
            this.btnDamier.Size = new System.Drawing.Size(328, 23);
            this.btnDamier.TabIndex = 2;
            this.btnDamier.Text = "Générer le damier";
            this.btnDamier.UseVisualStyleBackColor = true;
            this.btnDamier.Click += new System.EventHandler(this.BtnDamier_Click);
            // 
            // FrmDamier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 536);
            this.Controls.Add(this.btnDamier);
            this.Controls.Add(this.gBDamier);
            this.Controls.Add(this.pnlDamier);
            this.Name = "FrmDamier";
            this.Text = "Damier avec % ";
           
            this.gBDamier.ResumeLayout(false);
            this.gBDamier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nLargeur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nColonnes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLignes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDamier;
        private System.Windows.Forms.GroupBox gBDamier;
        private System.Windows.Forms.NumericUpDown nLargeur;
        private System.Windows.Forms.NumericUpDown nColonnes;
        private System.Windows.Forms.NumericUpDown nLignes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDamier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImpaire;
        private System.Windows.Forms.Button btnPaire;
    }
}

