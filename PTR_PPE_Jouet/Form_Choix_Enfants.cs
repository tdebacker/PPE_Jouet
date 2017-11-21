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
        string lemdp;
        string lelogin;

        public Form_Choix_Enfants(string login, string mdp)
        {
            InitializeComponent();
            lemdp = mdp;
            lelogin = login;
            
        }

        private void Form_Choix_Enfants_Load(object sender, EventArgs e)
        {
           
        }
    }
}
