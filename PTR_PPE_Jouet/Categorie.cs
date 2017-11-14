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
        private int qtte;

        //construct
        public Categorie(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }
        public Categorie(int id, string libelle, int qtte)
        {
            this.id = id;
            this.libelle = libelle;
            this.qtte = qtte;
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

        public override string ToString()
        {
            return "Libelle : "+getLibelle();
        }
    }
}
