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
    public partial class fen_Connexion : Form
    {
        public fen_Connexion()
        {
            InitializeComponent();
        }

        private void btn_connexion_Click(object sender, EventArgs e)
        {
            string login, mdp;

            login = txtbox_login.Text;
            mdp = txtbox_mdp.Text;
            try
            {
                if (Passerelle.Utilisateur(login, mdp) == true && login != null && mdp != null)
                {
                    if (Passerelle.EstResponsable(login) == true)
                    {
                        Fen_Recapitulatif uneF = new Fen_Recapitulatif(this);
                        uneF.Show();
                        this.Hide();
                    }
                    else
                    {
                        Form_Choix_Enfants unFormChoixEnfant = new Form_Choix_Enfants(login,mdp, this);
                        unFormChoixEnfant.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Identifiants invalides !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connexion impossible! \nVeuillez vérifier que vous êtes bien connecté au réseau.");
            }
        }

        private void fen_Connexion_Load(object sender, EventArgs e)
        {

        }

        private void fen_Connexion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
