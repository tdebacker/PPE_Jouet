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
    public partial class fen_ChoixModifierAjouterJouet : Form
    {
        Enfant enfant;
        Form fAppel;
        string login;
        string mdp;

        public fen_ChoixModifierAjouterJouet(Enfant enfant, Form pF, String login, String mdp)
        {
            InitializeComponent();

            this.enfant = enfant;
            fAppel = pF;
            this.login = login;
            this.mdp = mdp;
        }

        private void fen_ChoixModifierAjouterJouet_Load(object sender, EventArgs e)
        {
            lbl_NumEnfant.Text = enfant.getNom()+" "+enfant.getPrenom();
            cb_jouet.DataSource = Passerelle.ToutLesJouets(enfant.getAge());
            cb_jouet.DisplayMember = "Infos";
            cb_jouet.ValueMember = "Id";
        }

        private void btn_ValiderChoix_Click(object sender, EventArgs e)
        {
            int result = Passerelle.updateJouet((int)cb_jouet.SelectedValue, enfant.getId());

            if(result == 0)
            {
                MessageBox.Show("Erreur lors de l'ajout ou de la modification du jouet.");
            }
            else
            {
                Form_Choix_Enfants unFormChoixEnfant = new Form_Choix_Enfants(login, mdp, this);
                unFormChoixEnfant.Show();
                this.Hide();
            }            
        }

        private void lbl_NumEnfant_Click(object sender, EventArgs e)
        {

        }
    }
}
