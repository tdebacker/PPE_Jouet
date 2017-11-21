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
        public Form_Choix_Enfants()
        {
            InitializeComponent();
        }

        private void Form_Choix_Enfants_Load(object sender, EventArgs e)
        {
            cb_enfant.DataSource = Passerelle.EnfantsDeEmploye(3);  //en dur
        }

        private void cb_enfant_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
