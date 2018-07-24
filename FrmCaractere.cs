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
    public partial class FrmCaractere : Form
    {
        public FrmCaractere()
        {
            InitializeComponent();
        }

        private void btnCategorie_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtChaine.Text) && nudPosition.Value <= txtChaine.Text.Length )
            { 
                txtResultat.Text = VerifierCaractere(txtChaine.Text[(int)nudPosition.Value-1]);
            }
            else
            {
                txtResultat.Text = "Erreur";
            }
        }

        private string VerifierCaractere(char p)
        {
            if (char.IsLetter(p)) {return "Lettre";}
            else if (char.IsNumber(p)) {return "Chiffre";}
            else if (char.IsDigit(p)) {return "Chiffre décimal";}
            else if (char.IsPunctuation(p)) { return "Ponctuation"; }
            else return "Sais pas";
        }

        private void txtChaine_TextChanged(object sender, EventArgs e)
        {

            TextBox texte = sender as TextBox;
            if(texte.TextLength>0)
            {
                nudPosition.Enabled = true;
                nudPosition.Maximum = texte.TextLength;

            }
            else
            {
                nudPosition.Enabled = false;
            }
        }
    }
}
