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
    public partial class Fen_MenuGestion : Form
    {


        public Fen_MenuGestion()
        {
            InitializeComponent();

        }

        private void Fen_MenuGestion_Load(object sender, EventArgs e)
        {
        

            cb_listeEmploye.DataSource = Passerelle.lesEmployes();
            cb_listeEmploye.DisplayMember = "Infos";
            cb_listeEmploye.ValueMember = "Id";

            Personne uneP = (Personne)cb_listeEmploye.SelectedItem;


        }

        private void cb_listeEmploye_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_AjoutEnfant.Enabled = true;
            btn_ModifEmploye.Enabled = true;
            btn_ModifEnfant.Enabled = true;
        }

        private void btn_ModifEmploye_Click(object sender, EventArgs e)
        {
            Fen_GestionEmploye laFenGestion = new Fen_GestionEmploye((Personne)cb_listeEmploye.SelectedItem,1);
            laFenGestion.Show();
            this.Hide();
        }

        private void btn_AjoutEnfant_Click(object sender, EventArgs e)
        {
            Fen_GestionEmploye laFenGestion = new Fen_GestionEmploye((Personne)cb_listeEmploye.SelectedItem,3);
            laFenGestion.Show();
            this.Hide();
        }

        private void btn_ModifEnfant_Click(object sender, EventArgs e)
        {
            Fen_GestionEmploye laFenGestion = new Fen_GestionEmploye((Personne)cb_listeEmploye.SelectedItem, 2);
            laFenGestion.Show();
            this.Hide();
        }

        private void btn_NouvelleEmploye_Click(object sender, EventArgs e)
        {
            Fen_GestionEmploye laFenGestion = new Fen_GestionEmploye((Personne)cb_listeEmploye.SelectedItem, 4);
            laFenGestion.Show();
            this.Hide();
        }

        private void Fen_MenuGestion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
