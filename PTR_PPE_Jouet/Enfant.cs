using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTR_PPE_Jouet
{
    public class Enfant
    {
        //attributs
        private int id;
        private string nom;
        private string prenom;
        private int age;
        private Personne unEmploye;
        private Jouet unJouet;

        //construct
        public Enfant(int id, string nom, string prenom, int age, Personne unEmploye,Jouet unJouet)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.unEmploye = unEmploye;
            this.unJouet = unJouet;
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


        public string getPrenom()
        {
            return prenom;
        }

        public void setPrenom(string prenom)
        {
            this.prenom = prenom;
        }


        public int getAge()
        {
            return age;
        }

        public void setAge(int age)
        {
            this.age = age;
        }


        public Personne getUnEmploye()
        {
            return unEmploye;
        }

        public void setUnEmploye(Personne unEmploye)
        {
            this.unEmploye = unEmploye;
        }

        public Jouet getUnJouet()
        {
            return unJouet;
        }

        public void setUnJouet(Jouet jouet)
        {
            this.unJouet = jouet;
        }

        //propriété
        public string Infos
        {
            get { return nom+" "+prenom; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Jouet Jouet
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Personne Employe
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
