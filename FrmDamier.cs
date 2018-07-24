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
    public partial class FrmDamier : Form
    {
        public FrmDamier()
        {
            InitializeComponent();

        }
        private void CreerDamier()
        {
            int nbParLignes = (int)nColonnes.Value;
            int nbLignes = (int)nLignes.Value;
           
            Color couleurPaire = btnPaire.BackColor;
            Color couleurImpaire = btnImpaire.BackColor;
            pnlDamier.AutoSize = true;
            this.AutoSize = true;

            int haut = (int)nLargeur.Value;
            int larg = (int)nLargeur.Value; ;
            DessinerDamier(nbLignes, nbParLignes, couleurPaire, couleurImpaire, larg, haut);

        }

        private void DessinerDamier(int nblignes, int nbParLignes,
            Color couleurPaire,Color couleurImpaire,int larg, int haut)
        {
            int posV, posH;
            for (int i = 0; i < nblignes; i++)
            {
                posV = i * haut;
                for (int j = 0; j < nbParLignes; j++)
                {
                    Button bouton = new Button()
                    {
                        Padding = new Padding(0, 0, 0, 0),
                        Margin = new Padding(0, 0, 0, 0),
                        Height = haut,
                        Width = larg
                    };
                    posH = j * larg;
                    bouton.Location = new Point(posH, posV);
                    bouton.BackColor = ((i + 1 * j + 1) % 2 == 0)
                        ? couleurPaire
                        : couleurImpaire;

                    pnlDamier.Controls.Add(bouton);
                }
            }
        }

        private void BtnDamier_Click(object sender, EventArgs e)
        {
            pnlDamier.Controls.Clear();
            CreerDamier();

        }

        private void ChangerCouleur(object sender, EventArgs e)
        {
            Button bouton = sender as Button;
            ColorDialog boiteCouleur = new ColorDialog();
            bouton.BackColor = (boiteCouleur.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                ? boiteCouleur.Color : bouton.BackColor;
        }


    }
}
