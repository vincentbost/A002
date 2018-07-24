using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A002
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void damierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDamier damier = new FrmDamier();
            damier.Show();
        }

        private void chaineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChaineCaracteres chaines = new FrmChaineCaracteres();
            chaines.Show();
        }

        private void caractereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCaractere caractere = new FrmCaractere();
            caractere.Show();
        }
    }
}
