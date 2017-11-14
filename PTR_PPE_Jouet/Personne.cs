using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTR_PPE_Jouet
{
    class Personne
    {
        //attributs
        private int id;
        private string nom;
        private string numAdr;
        private string rue;
        private string ville;
        private int cp;
        private string mail;
        private string mdp;
        private bool estResponsable;
        private bool aValide;

        //construct
        public Personne(int id, string nom, string numAdr, string rue, string ville, int cp, string mail, string mdp, bool estResponsable, bool aValide)
        {
            this.id = id;
            this.nom = nom;
            this.numAdr = numAdr;
            this.rue = rue;
            this.ville = ville;
            this.cp = cp;
            this.mail = mail;
            this.mdp = mdp;
            this.estResponsable = estResponsable;
            this.aValide = aValide;
        }

        //get/set
        public int getId()
        {
            return id;
        }


        public string getNom()
        {
            return nom;
        }

        public void setNom(string nom)
        {
            this.nom = nom;
        }


        public string getNumAdr()
        {
            return numAdr;
        }

        public void setNumAdr(string numAdr)
        {
            this.numAdr = numAdr;
        }


        public string getRue()
        {
            return rue;
        }

        public void setRue(string rue)
        {
            this.rue = rue;
        }


        public string getVille()
        {
            return ville;
        }

        public void setVille(string ville)
        {
            this.ville = ville;
        }


        public int getCp()
        {
            return cp;
        }

        public void getCp(int cp)
        {
            this.cp = cp;
        }


        public string getMail()
        {
            return mail;
        }

        public void setMail(string mail)
        {
            this.mail = mail;
        }


        public string getMdp()
        {
            return mdp;
        }

        public void setMdp(string mdp)
        {
            this.mdp = mdp;
        }


        public bool getEstResponsable()
        {
            return estResponsable;
        }

        public void setEstResponsable(bool estResponsable)
        {
            this.estResponsable = estResponsable;
        }


        public bool getAValide()
        {
            return aValide;
        }

        public void setAValide(bool aValide)
        {
            this.aValide = aValide;
        }
    }
}
