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
        {
            int nbTotal ;
            nbTotal = Passerelle.GetnbJouetTotal();

            Txt_nbJouetTotal.Text = nbTotal.ToString();
            Txt_nbJouetTotal.ReadOnly = true;
        }
    }
}
