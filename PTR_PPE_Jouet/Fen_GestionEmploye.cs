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
    public partial class Fen_GestionEmploye : Form
    {
        Personne unePersonne;
        int choixBtn;
        public Fen_GestionEmploye(Personne unePersonne , int choixBtn)
        {
            InitializeComponent();
            this.unePersonne = unePersonne;
            this.choixBtn = choixBtn;
        }

        private void Fen_GestionEmploye_Load(object sender, EventArgs e)
        {


            switch (choixBtn)
            {

                //BOUTON MODIF ENMPLOYE
                case 1 :

                     txt_nom.Text = unePersonne.getNom();
                     txt_prenom.Text = unePersonne.getPrenom();
                     txt_email.Text = unePersonne.getMail();
                     txtRue.Text = unePersonne.getRue();
                     txt_cp.Text = unePersonne.getCp();
                     txtVille.Text = unePersonne.getVille();
                     txt_numero.Text = unePersonne.getNumAdr();

                     panelGestionEnfants.Enabled = false;
                   
               

                     break;
                
                //BOUTON MODIF ENFANT DE LEMPLOYE
                case 2 :

                     btn_supprimer.Visible = true;


                     txt_nom.Text = unePersonne.getNom();
                     txt_prenom.Text = unePersonne.getPrenom();
                     txt_email.Text = unePersonne.getMail();
                     txtRue.Text = unePersonne.getRue();
                     txt_cp.Text = unePersonne.getCp();
                     txtVille.Text = unePersonne.getVille();

                     cb_enfant.DataSource = Passerelle.EnfantsDeEmploye(unePersonne.getId());
                     cb_enfant.DisplayMember = "Infos";
                     cb_enfant.ValueMember = "Id";
                     

                     Enfant unE =(Enfant)cb_enfant.SelectedItem;

                     txt_ageE.Text = "" + unE.getAge();
                     txt_nomE.Text = unE.getNom();
                     txt_prenomE.Text = unE.getPrenom();

                    
                    
                    
                    panelGestionEmploye.Enabled = false;


                     


                     break;


                //NEW ENFANT
                case 3 :

                     panelGestionEmploye.Enabled = false;
                     cb_enfant.Enabled = false;
                     txt_nomE.Text = unePersonne.getNom();
                     break;

                //NEW EMPLOYE
                case 4:
                     panelGestionEnfants.Enabled = false;


                     break;
           


            }

          



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cb_enfant_SelectedIndexChanged(object sender, EventArgs e)
        {

           switch (choixBtn)
           {

               //BOUTON MODIF ENMPLOYE
               case 1:
                   
                   btn_supprimer.Visible = true;


                   break;

               //BOUTON MODIF ENFANT DE LEMPLOYE
               case 2:
                   
                   btn_supprimer.Visible = true;

                    Enfant unE = (Enfant)cb_enfant.SelectedItem;

                    txt_ageE.Text = "" + unE.getAge();
                    txt_nomE.Text = unE.getNom();
                    txt_prenomE.Text = unE.getPrenom();








                   break;


               //NEW ENFANT
               case 3:

                   

                   break;

               //NEW EMPLOYE
               case 4:


                   break;



           }
                     

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            Enfant unE = (Enfant)cb_enfant.SelectedItem;

            switch (choixBtn)
            {

                //BOUTON MODIF ENMPLOYE
                case 1:

                    string nomEm, emailEm, adrRueEm, villeEm, cpEm,numAdr,prenomEm;

                    nomEm = txt_nom.Text;
                    prenomEm = txt_prenom.Text;
                    emailEm =txt_email.Text;
                    adrRueEm = txtRue.Text;
                    cpEm =txt_cp.Text;
                    villeEm = txtVille.Text;
                    numAdr = txt_numero.Text;

                    unePersonne.setNom(nomEm);
                    unePersonne.setMail(emailEm);
                    unePersonne.setVille(villeEm);
                    unePersonne.setRue(numAdr);
                    unePersonne.setPrenom(prenomEm);
                    unePersonne.setCp(cpEm);

                    int result = Passerelle.updateEmploye(unePersonne.getId(),numAdr,nomEm,prenomEm,emailEm,adrRueEm,villeEm,cpEm);

                    if (result == 1)
                    {
                        new Fen_MenuGestion().Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("ERREUR");
                    }

                    break;

                //BOUTON MODIF ENFANT DE LEMPLOYE
                case 2:

                    string nomEnf, prenomEnf;
                    int ageEnf;

                    nomEnf = txt_nomE.Text;
                    prenomEnf = txt_prenomE.Text;
                    ageEnf = Convert.ToInt32(txt_ageE.Text);

                    unE.setAge(ageEnf);
                    unE.setNom(nomEnf);
                    unE.setPrenom(prenomEnf);

                    int resultE = Passerelle.updateEnfant(unE.getId(), unE.getNom(), unE.getPrenom(), unE.getAge());

                    if (resultE == 1)
                    {
                        new Fen_MenuGestion().Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("ERREUR");
                    }

                    break;







                //NEW ENFANT
                case 3:
                     

                    string nomEnfAdd, prenomEnfAdd;
                    int ageEnfAdd;

                   

                    nomEnfAdd = txt_nomE.Text;
                    prenomEnfAdd = txt_prenomE.Text;
                    ageEnfAdd = Convert.ToInt32(txt_ageE.Text);

                    int resultAdd = Passerelle.AjoutEnfant(nomEnfAdd, prenomEnfAdd, ageEnfAdd,unePersonne.getId());

                    if (resultAdd == 1)

                        {
                            new Fen_MenuGestion().Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("ERREUR");
                        }

                    break;



                    

                //NEW EMPLOYE
                case 4:
                    string nom, prenom, numAdrEmp, rue, ville, cp, mail;

                   


                    nom = txt_nom.Text;
                    prenom = txt_prenom.Text;
                    mail =txt_email.Text;
                    rue = txtRue.Text;
                    cp =txt_cp.Text;
                    ville = txtVille.Text;
                    numAdrEmp = txt_numero.Text;

                    int resultAddEmp = Passerelle.AjoutEmploye(nom, prenom, numAdrEmp, rue, ville, cp, mail);

                    if (resultAddEmp == 1)

                        {
                            new Fen_MenuGestion().Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("ERREUR");
                        }

                    break;



            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
             Enfant unE = (Enfant)cb_enfant.SelectedItem;

            if (choixBtn == 2)
            {
                //SUPPRESION ENFANT

                if (MessageBox.Show("Etes-vous sûr de supprimer l'enfant?", "Suppression",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
                {
                    Passerelle.deleteEnfant(unE.getId());
                    this.Close();
                }
            }
            else
            {
                if (MessageBox.Show("Etes-vous sûr de supprimer l'employé?", "Suppression",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question)
               == DialogResult.Yes)
                {
                   
                    this.Close();
                }
            }
        }
    }
}
