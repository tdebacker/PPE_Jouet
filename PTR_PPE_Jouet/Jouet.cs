﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTR_PPE_Jouet
{
    public class Jouet
    {
        //attributs
        private int id;
        private string libelle;
        private Categorie uneCategorie;
        private TrancheAge uneTrancheAge;
        private int qtte;

        //construct
        public Jouet(int id, string libelle, Categorie uneCategorie, TrancheAge uneTrancheAge, int qtte)
        {
            this.id = id;
            this.libelle = libelle;
            this.uneCategorie = uneCategorie;
            this.uneTrancheAge = uneTrancheAge;
            this.qtte = qtte;
        }

        public Jouet(int id, string libelle, Categorie uneCategorie, TrancheAge uneTrancheAge)
        {
            this.id = id;
            this.libelle = libelle;
            this.uneCategorie = uneCategorie;
            this.uneTrancheAge = uneTrancheAge;
        }


        //get/set
        public int getId()
        {
            return id;
        }

        public int getQtte()
        {
            return qtte;
        }

        public string getLibelle()
        {
            return libelle;
        }

        public void setLibelle(string libelle)
        {
            this.libelle = libelle;
        }


        public Categorie getUneCategorie()
        {
            return uneCategorie;
        }

        public void setUneCategorie(Categorie uneCategorie)
        {
            this.uneCategorie = uneCategorie;
        }


        public TrancheAge getUneTrancheAge()
        {
            return uneTrancheAge;
        }

        public void setUneTrancheAge(TrancheAge uneTrancheAge)
        {
            this.uneTrancheAge = uneTrancheAge;
        }

        public String Infos
        {
            get { return libelle + " - " + uneCategorie.getLibelle(); }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public override string ToString()
        {
            return libelle+" - "+uneCategorie.getLibelle();
        }

        public TrancheAge TrancheAge
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Categorie Categorie
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
