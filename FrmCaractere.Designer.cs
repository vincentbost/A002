namespace A002
{
    partial class FrmCaractere
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
            this.txtChaine = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudPosition = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResultat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCategorie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // txtChaine
            // 
            this.txtChaine.Location = new System.Drawing.Point(182, 41);
            this.txtChaine.Name = "txtChaine";
            this.txtChaine.Size = new System.Drawing.Size(287, 22);
            this.txtChaine.TabIndex = 1;
            this.txtChaine.TextChanged += new System.EventHandler(this.txtChaine_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saisissez une chaine :";
            // 
            // nudPosition
            // 
            this.nudPosition.Enabled = false;
            this.nudPosition.Location = new System.Drawing.Point(182, 79);
            this.nudPosition.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPosition.Name = "nudPosition";
            this.nudPosition.Size = new System.Drawing.Size(120, 22);
            this.nudPosition.TabIndex = 3;
            this.nudPosition.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Position du caractère :";
            // 
            // txtResultat
            // 
            this.txtResultat.Enabled = false;
            this.txtResultat.Location = new System.Drawing.Point(183, 124);
            this.txtResultat.Name = "txtResultat";
            this.txtResultat.ReadOnly = true;
            this.txtResultat.Size = new System.Drawing.Size(287, 22);
            this.txtResultat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Résultat :";
            // 
            // btnCategorie
            // 
            this.btnCategorie.Location = new System.Drawing.Point(30, 163);
            this.btnCategorie.Name = "btnCategorie";
            this.btnCategorie.Size = new System.Drawing.Size(202, 23);
            this.btnCategorie.TabIndex = 6;
            this.btnCategorie.Text = "Catégorie du caractère";
            this.btnCategorie.UseVisualStyleBackColor = true;
            this.btnCategorie.Click += new System.EventHandler(this.btnCategorie_Click);
            // 
            // FrmCaractere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 279);
            this.Controls.Add(this.btnCategorie);
            this.Controls.Add(this.nudPosition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResultat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChaine);
            this.Name = "FrmCaractere";
            this.Text = "Catégorie du caractère";
            ((System.ComponentModel.ISupportInitialize)(this.nudPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChaine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudPosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCategorie;
    }
}