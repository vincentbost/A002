namespace A002
{
    partial class FrmChaineCaracteres
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
            this.btnJouer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChaine = new System.Windows.Forms.TextBox();
            this.txtPortion1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPortion2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbChoix = new System.Windows.Forms.GroupBox();
            this.rdbRemplacerDerniere = new System.Windows.Forms.RadioButton();
            this.rdbRemplacerPremiere = new System.Windows.Forms.RadioButton();
            this.rdbRemplacerToutes = new System.Windows.Forms.RadioButton();
            this.rdbNombreOccurences = new System.Windows.Forms.RadioButton();
            this.gbChoix.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnJouer
            // 
            this.btnJouer.Location = new System.Drawing.Point(62, 468);
            this.btnJouer.Name = "btnJouer";
            this.btnJouer.Size = new System.Drawing.Size(103, 28);
            this.btnJouer.TabIndex = 9;
            this.btnJouer.Text = "Jouer";
            this.btnJouer.UseVisualStyleBackColor = true;
            this.btnJouer.Click += new System.EventHandler(this.btnJouer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Résultat :";
            // 
            // txtResultat
            // 
            this.txtResultat.Location = new System.Drawing.Point(248, 169);
            this.txtResultat.Name = "txtResultat";
            this.txtResultat.ReadOnly = true;
            this.txtResultat.Size = new System.Drawing.Size(287, 22);
            this.txtResultat.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saisissez une chaine :";
            // 
            // txtChaine
            // 
            this.txtChaine.Location = new System.Drawing.Point(247, 52);
            this.txtChaine.Name = "txtChaine";
            this.txtChaine.Size = new System.Drawing.Size(287, 22);
            this.txtChaine.TabIndex = 1;
            // 
            // txtPortion1
            // 
            this.txtPortion1.Location = new System.Drawing.Point(248, 93);
            this.txtPortion1.Name = "txtPortion1";
            this.txtPortion1.Size = new System.Drawing.Size(287, 22);
            this.txtPortion1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Portion de chaîne 1 :";
            // 
            // txtPortion2
            // 
            this.txtPortion2.Location = new System.Drawing.Point(248, 128);
            this.txtPortion2.Name = "txtPortion2";
            this.txtPortion2.Size = new System.Drawing.Size(287, 22);
            this.txtPortion2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Portion de remplacement 2 :";
            // 
            // gbChoix
            // 
            this.gbChoix.Controls.Add(this.rdbRemplacerDerniere);
            this.gbChoix.Controls.Add(this.rdbRemplacerPremiere);
            this.gbChoix.Controls.Add(this.rdbRemplacerToutes);
            this.gbChoix.Controls.Add(this.rdbNombreOccurences);
            this.gbChoix.Location = new System.Drawing.Point(62, 212);
            this.gbChoix.Name = "gbChoix";
            this.gbChoix.Size = new System.Drawing.Size(476, 223);
            this.gbChoix.TabIndex = 8;
            this.gbChoix.TabStop = false;
            this.gbChoix.Text = "Faites votre choix";
            // 
            // rdbRemplacerDerniere
            // 
            this.rdbRemplacerDerniere.AutoSize = true;
            this.rdbRemplacerDerniere.Location = new System.Drawing.Point(7, 103);
            this.rdbRemplacerDerniere.Name = "rdbRemplacerDerniere";
            this.rdbRemplacerDerniere.Size = new System.Drawing.Size(293, 21);
            this.rdbRemplacerDerniere.TabIndex = 3;
            this.rdbRemplacerDerniere.Text = "Remplacer dernière occurence de 1 par 2";
            this.rdbRemplacerDerniere.UseVisualStyleBackColor = true;
            // 
            // rdbRemplacerPremiere
            // 
            this.rdbRemplacerPremiere.AutoSize = true;
            this.rdbRemplacerPremiere.Location = new System.Drawing.Point(7, 76);
            this.rdbRemplacerPremiere.Name = "rdbRemplacerPremiere";
            this.rdbRemplacerPremiere.Size = new System.Drawing.Size(249, 21);
            this.rdbRemplacerPremiere.TabIndex = 2;
            this.rdbRemplacerPremiere.Text = "Remplacer 1ère occurence 1 par 2";
            this.rdbRemplacerPremiere.UseVisualStyleBackColor = true;
            // 
            // rdbRemplacerToutes
            // 
            this.rdbRemplacerToutes.AutoSize = true;
            this.rdbRemplacerToutes.Location = new System.Drawing.Point(7, 49);
            this.rdbRemplacerToutes.Name = "rdbRemplacerToutes";
            this.rdbRemplacerToutes.Size = new System.Drawing.Size(308, 21);
            this.rdbRemplacerToutes.TabIndex = 1;
            this.rdbRemplacerToutes.Text = "Remplacer toutes les occurences de 1 par 2";
            this.rdbRemplacerToutes.UseVisualStyleBackColor = true;
            // 
            // rdbNombreOccurences
            // 
            this.rdbNombreOccurences.AutoSize = true;
            this.rdbNombreOccurences.Checked = true;
            this.rdbNombreOccurences.Location = new System.Drawing.Point(7, 22);
            this.rdbNombreOccurences.Name = "rdbNombreOccurences";
            this.rdbNombreOccurences.Size = new System.Drawing.Size(168, 21);
            this.rdbNombreOccurences.TabIndex = 0;
            this.rdbNombreOccurences.TabStop = true;
            this.rdbNombreOccurences.Text = "Nombre occurences 1";
            this.rdbNombreOccurences.UseVisualStyleBackColor = true;
            // 
            // FrmChaineCaracteres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 527);
            this.Controls.Add(this.gbChoix);
            this.Controls.Add(this.btnJouer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResultat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPortion2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPortion1);
            this.Controls.Add(this.txtChaine);
            this.Name = "FrmChaineCaracteres";
            this.Text = "Jouez avec les chaînes de caractères";
            this.gbChoix.ResumeLayout(false);
            this.gbChoix.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJouer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResultat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChaine;
        private System.Windows.Forms.TextBox txtPortion1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPortion2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbChoix;
        private System.Windows.Forms.RadioButton rdbRemplacerDerniere;
        private System.Windows.Forms.RadioButton rdbRemplacerPremiere;
        private System.Windows.Forms.RadioButton rdbRemplacerToutes;
        private System.Windows.Forms.RadioButton rdbNombreOccurences;
    }
}