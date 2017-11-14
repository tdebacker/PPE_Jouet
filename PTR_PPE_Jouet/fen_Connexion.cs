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
         //   EspaceEmploye unEspaceEmploye = new EspaceEmploye();
         //   EspaceResponsable unEspaceResponsable = new EspaceResponsable();
            fen_ChoixModifierAjouterJouet unChoix = new fen_ChoixModifierAjouterJouet();

            login = txtbox_login.Text;
            mdp = txtbox_mdp.Text;
            try
            {
                if (Passerelle.Utilisateur(login, mdp) == true && login != null && mdp != null)
                {
                    if (Passerelle.EstResponsable(login) == true)
                    {
                        MessageBox.Show("Vous êtes connecté en tant que Responsable ! ");
                        //unEspaceResponsable.Show();
                        Fen_Recapitulatif uneF = new Fen_Recapitulatif();
                        uneF.Show();
                    }
                    else
                    {
                        MessageBox.Show("Vous êtes connecté en tant que Employé ! ");
                        unChoix.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Identifiants invalides !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Identifiants invalides !" + ex.Message);
            }
        }
    }
}
