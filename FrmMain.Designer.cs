namespace A002
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.damierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chaineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caractereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.damierToolStripMenuItem,
            this.chaineToolStripMenuItem,
            this.caractereToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(282, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // damierToolStripMenuItem
            // 
            this.damierToolStripMenuItem.Name = "damierToolStripMenuItem";
            this.damierToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.damierToolStripMenuItem.Text = "Damier";
            this.damierToolStripMenuItem.Click += new System.EventHandler(this.damierToolStripMenuItem_Click);
            // 
            // chaineToolStripMenuItem
            // 
            this.chaineToolStripMenuItem.Name = "chaineToolStripMenuItem";
            this.chaineToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.chaineToolStripMenuItem.Text = "Chaine";
            this.chaineToolStripMenuItem.Click += new System.EventHandler(this.chaineToolStripMenuItem_Click);
            // 
            // caractereToolStripMenuItem
            // 
            this.caractereToolStripMenuItem.Name = "caractereToolStripMenuItem";
            this.caractereToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.caractereToolStripMenuItem.Text = "Caractere";
            this.caractereToolStripMenuItem.Click += new System.EventHandler(this.caractereToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem damierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chaineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caractereToolStripMenuItem;
    }
}