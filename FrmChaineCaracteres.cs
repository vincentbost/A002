using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

// using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A002
{
    public partial class FrmChaineCaracteres : Form
    {
        public FrmChaineCaracteres()
        {
            InitializeComponent();

        }

        private string RemplacerToutes(string chaineOrigine, string portionCherchee, string portionRemplacement)
        {
            return chaineOrigine.Replace(portionCherchee, portionRemplacement);
        }
        private string RemplacerPremiere(string chaineOrigine, string portionCherchee, string portionRemplacement)
        {
            int posPremiere = chaineOrigine.IndexOf(portionCherchee);
            return (posPremiere == -1 || portionCherchee == string.Empty)
                ? chaineOrigine
                : chaineOrigine.Remove(posPremiere, portionCherchee.Length).Insert(posPremiere, portionRemplacement);
           
        }
        private string RemplacerDerniere(string chaineOrigine, string portionCherchee, string portionRemplacement)
        {
           
            int pos = chaineOrigine.LastIndexOf(portionCherchee);
            return (pos == -1 || portionCherchee == string.Empty)
                ? chaineOrigine
                : chaineOrigine.Remove(pos, portionCherchee.Length).Insert(pos, portionRemplacement) ;

        }
        private int CompterInstances(string chaineOrigine, string portionCherchee)
        {
            int nbreOccurences = 0, pos = 0;
            
                while (portionCherchee!= string.Empty && (pos = chaineOrigine.IndexOf(portionCherchee, pos)) != -1)
                {
                    pos += portionCherchee.Length;
                    nbreOccurences++;
                }
             return nbreOccurences;

        }
        private void btnJouer_Click(object sender, EventArgs e)
        {
            switch (RechercherBoutonSel(gbChoix))
            {
                case "rdbNombreOccurences":
                    txtResultat.Text = CompterInstances(txtChaine.Text,txtPortion1.Text).ToString();
                    break;
                case "rdbRemplacerToutes":
                    txtResultat.Text = RemplacerToutes(txtChaine.Text, txtPortion1.Text,txtPortion2.Text);
                    break;
                case "rdbRemplacerPremiere":
                    txtResultat.Text = RemplacerPremiere(txtChaine.Text, txtPortion1.Text, txtPortion2.Text);
                    break;
                case "rdbRemplacerDerniere":
                    txtResultat.Text = RemplacerDerniere(txtChaine.Text, txtPortion1.Text, txtPortion2.Text);
                    break;
                default:
 break;
            }
        }
        private string RechercherBoutonSel(GroupBox groupe)
        {
            foreach (var item  in groupe.Controls)
            {
                RadioButton bouton = item as RadioButton;
                if (bouton.Checked) return bouton.Name;
            }
            return string.Empty;
        }
    }
}
