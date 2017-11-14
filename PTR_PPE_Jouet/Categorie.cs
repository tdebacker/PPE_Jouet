using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTR_PPE_Jouet
{
    class Categorie
    {
        //attributs
        private int id;
        private string libelle;

        //construct
        public Categorie(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }


        //get/set
        public int getId()
        {
            return id;
        }


        public string getLibelle()
        {
            return libelle;
        }

        public void setLibelle(string libelle)
        {
            this.libelle = libelle;
        }
    }
}
