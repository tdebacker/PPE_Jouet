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
    public partial class Form_Choix_Enfants : Form
    {
        //attributs
        string unLogin;
        string unMdp;
        Form fAppel;

        public Form_Choix_Enfants(string login, string mdp, Form pF)
        {
            InitializeComponent();

            unLogin = login;
            unMdp = mdp;
            fAppel = pF;
        }

        private void Form_Choix_Enfants_Load(object sender, EventArgs e)
        {
            int idEmp = Passerelle.recupIdEmploye(unLogin, unMdp);
            cb_enfant.DataSource = Passerelle.EnfantsDeEmploye(idEmp);
            cb_enfant.DisplayMember = "Infos";
            cb_enfant.ValueMember = "Id";
            Enfant unEnfant = (Enfant)cb_enfant.SelectedItem;
            
            Jouet unJouet = Passerelle.getLeJouet(unEnfant.getId());

            lbl_jouetCorrespondant.Text = unJouet.getLibelle();
        }

        private void cb_enfant_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enfant unEnfant = (Enfant)cb_enfant.SelectedItem;

            Jouet unJouet = Passerelle.getLeJouet(unEnfant.getId());

            lbl_jouetCorrespondant.Text = unJouet.getLibelle();
        }

        private void btn_cloturer_Click(object sender, EventArgs e)
        {
            int idEmp = Passerelle.recupIdEmploye(unLogin, unMdp);
            bool result = Passerelle.aValide(idEmp);

            if(result == false)
            {
                int modif = Passerelle.updateAValide(idEmp);
                if(modif == 1)
                {
                    MessageBox.Show("Votre choix est désormais cloturé.");
                }
                else
                {
                    MessageBox.Show("La cloturation a échouée.");
                }
            }
            else
            {
                MessageBox.Show("Votre choix est déjà cloturé.");
            }
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            new fen_Connexion().Show();
            this.Hide();
        }

        private void btn_modifierAjouter_Click(object sender, EventArgs e)
        {
            fen_ChoixModifierAjouterJouet formAjoutModif = new fen_ChoixModifierAjouterJouet((Enfant)cb_enfant.SelectedItem, this, unLogin, unMdp);
            formAjoutModif.Show();
            this.Hide();
        }

        private void Form_Choix_Enfants_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
