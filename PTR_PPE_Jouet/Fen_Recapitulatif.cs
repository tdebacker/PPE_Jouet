using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTR_PPE_Jouet
{
    public partial class Fen_Recapitulatif : Form
    {
        public Fen_Recapitulatif()
        {
            InitializeComponent();
        }

        private void auLoad(object sender, EventArgs e)
        { //NB TOTAL 
            int nbTotal ;
            nbTotal = Passerelle.GetnbJouetTotal();
            Txt_nbJouetTotal.Text = nbTotal.ToString();
            Txt_nbJouetTotal.ReadOnly = true;

            //TABLEAU PANEL LES JOUETS COMMANDE

            List<Jouet> lesJouetsAcomm = new List<Jouet>();
            List<Categorie> lesJouetsCateg = new List<Categorie>();
            //INSERTION JOUET COMM

            lesJouetsAcomm=Passerelle.ToutLesJouetsCommande();
            lesJouetsCateg = Passerelle.ToutLesJouetsCat();

            foreach (Jouet unJ in lesJouetsAcomm)
            {

                ListViewItem itm = new ListViewItem();

                itm = new ListViewItem(unJ.getId().ToString());
                itm.SubItems.Add(unJ.getLibelle());
                itm.SubItems.Add(unJ.getUneCategorie().getLibelle().ToString());
                itm.SubItems.Add(unJ.getQtte().ToString());
                ListV_JouetsAcom.Items.Add(itm);
            }

            foreach (Categorie uneC in lesJouetsCateg)
            {

                ListViewItem itm2 = new ListViewItem();

                itm2 = new ListViewItem(uneC.getLibelle().ToString());
                itm2.SubItems.Add(uneC.getQtte().ToString());
                ListV_CategorieVente.Items.Add(itm2);
                
            }

        }
    }
}
