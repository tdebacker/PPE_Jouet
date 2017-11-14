using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace PTR_PPE_Jouet
{
    class Passerelle
    {
        private static SqlConnection laConnexion = null;

        private static bool seConnecter()
        {
            if (laConnexion == null)
            {
                laConnexion = new SqlConnection();
                laConnexion.ConnectionString = "Data Source =  win-921c8fktgae; Initial Catalog=slam2018PPEJouetPTR; User ID = debacker; Password= debacker";
                laConnexion.Open();
                System.Diagnostics.Debug.WriteLine("Instanciation de la connexion");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Connexion existe");
            }
            return true;
        }

        public static bool seDeconnecter()
        {
            if (laConnexion != null)
            {
                laConnexion.Close();
                System.Diagnostics.Debug.WriteLine(laConnexion.State);
                laConnexion = null;
                System.Diagnostics.Debug.WriteLine("Déconnexion");
            }
            return true;
        }
        public static Boolean Utilisateur(String mail, String mdp)
        {
            seConnecter();
            SqlCommand maCommande;

            string requeteIdentifiant = "SELECT * FROM Personne WHERE mail = '" + mail + "'";

            maCommande = new SqlCommand(requeteIdentifiant, laConnexion);

            SqlDataReader Resultat = maCommande.ExecuteReader();

            Boolean i = false;

            while (Resultat.Read())
            {
                string motdepasse = (string)Resultat["mdp"];
                if (mdp == motdepasse)
                {
                    i = true;
                }
            }
            Resultat.Close();
            return i;
        }

        public static bool EstResponsable(string mail)
        {
            seConnecter();

            SqlCommand maCommande;

            string requeteInfoResponsable = "SELECT estResponsable FROM Personne WHERE mail = '" + mail + "'";

            maCommande = new SqlCommand(requeteInfoResponsable, laConnexion);

            bool Resultat = (bool)maCommande.ExecuteScalar();

            return Resultat;

        }

        /*
        public static List<Enfant> EnfantsDeEmploye(int idEmploye)
        {
            
            seConnecter();
            List<Enfant> lesEnfants = new List<Enfant>();
            SqlCommand maCommande;
            string requeteIdentifiant = "SELECT E.id,E.nom,E.prenom,E.age,E.idJouet,E.idEmploye,P.id,P.nom,P.prenom,P.numAdr,P.rue,P.ville,P.cp,P.mail,P.mdp,P.estResponsable,P.aValide FROM Enfant E JOIN Personne P ON (E.idEmploye=P.id) JOIN Jouet J ON(E.idJouet=J.id) WHERE idEmploye ="+idEmploye; // recupere les informations
            maCommande = new SqlCommand(requeteIdentifiant, laConnexion);
            SqlDataReader Resultat = maCommande.ExecuteReader();
           
            while (Resultat.Read()) //Parcours le resultat
            {
                int pIdE = (int)Resultat["id"];
                string pNom = (string)Resultat["nom"];
                string pPrenom = (string)Resultat["prenom"];
                int pAge = (int)Resultat["age"];
                int pIdJ =(int)Resultat["idJouet"];
                int pIdEm =(int)Resultat["idEmploye"];
                string pNomEm = (string)Resultat["nom"];
                string pPrenomEm = (string)Resultat["prenom"];
                string pnumAdre = (string)Resultat["numAdr"];
                string pRue = (string)Resultat["rue"];
                string pVille = (string)Resultat["ville"];
                int pCp = (int)Resultat["cp"];
                string pMail = (string)Resultat["mail"];
                string pMdp = (string)Resultat["mdp"];
                bool pEstRes = (bool)Resultat["estResponsable"];
                bool pEstValide = (bool)Resultat["aValide"];
                Personne unePersonne = new Personne(pIdEm, pNomEm, pnumAdre, pRue, pVille, pCp, pMail, pMdp, pEstRes, pEstValide);
                Jouet unJouet = new Jouet(pIdJ,);
                Enfant unEnfant = new Enfant(pIdE,pNom,pPrenom,pAge,unePersonne,);
                //recup les enfants de lemploye

            }
            return lesEnfants;
        }

        */
        
        public static List<Jouet> ToutLesJouets()
        {
            seConnecter();
            List<Jouet> JouetList = new List<Jouet>();
            SqlCommand maCommande;
            string requeteIdentifiant = "SELECT J.id , J.libelle , J.idCategorie , J.idTrancheAge , C.libelle , T.ageMin FROM Jouet J JOIN Categorie C ON (J.idCategorie = C.id) JOIN TrancheAge T ON (J.idTrancheAge=T.id)  "; // recupere les informations
            maCommande = new SqlCommand(requeteIdentifiant, laConnexion);
            SqlDataReader Resultat = maCommande.ExecuteReader();
            while (Resultat.Read()) //Parcours le resultat
            {
                int pId = (int)Resultat["id"];
                string pLibelle = (string)Resultat["libelle"];
                int pIdC = (int)Resultat["idCategorie"];
                int pIdT = (int)Resultat["idTrancheAge"];
                string pLibelleC = (string)Resultat["libelle"];
                int pAgeMin = (int)Resultat["ageMin"];
                int pQtte = 0;

                Categorie uneCategorie = new Categorie(pIdC, pLibelleC);
                TrancheAge uneTrancheA = new TrancheAge(pIdT, pAgeMin);
                Jouet unJouet = new Jouet(pId, pLibelle, uneCategorie, uneTrancheA, pQtte);
                JouetList.Add(unJouet);

            }
            return JouetList;     
        }
        public static List<Jouet> ToutLesJouetsCommande()
        {
            seConnecter();
            List<Jouet> pJouetList;
            pJouetList = new List<Jouet>();
            SqlCommand maCommande;
            string requeteIdentifiant = "SELECT J.id , J.libelle , J.idCategorie , J.idTrancheAge , C.libelle AS libelleC , T.ageMin , COUNT(E.idJouet) AS nbCom FROM Jouet J JOIN Categorie C ON (J.idCategorie = C.id) JOIN TrancheAge T ON (J.idTrancheAge=T.id) JOIN Enfant E ON (E.idJouet=J.id) GROUP BY E.idJouet,J.id , J.libelle , J.idCategorie , J.idTrancheAge , C.libelle , T.ageMin "; // recupere les informations
            maCommande = new SqlCommand(requeteIdentifiant, laConnexion);
            SqlDataReader Resultat = maCommande.ExecuteReader();
            while (Resultat.Read()) //Parcours le resultat
            {
                int pId = (int)Resultat["id"];
                string pLibelle = (string)Resultat["libelle"];
                int pIdC = (int)Resultat["idCategorie"];
                int pIdT = (int)Resultat["idTrancheAge"];
                string pLibelleC = (string)Resultat["libelleC"];
                int pAgeMin = (int)Resultat["ageMin"];
                int pQtte = (int)Resultat["nbCom"];

                Categorie uneCategorie = new Categorie(pIdC, pLibelleC);
                TrancheAge uneTrancheA = new TrancheAge(pIdT, pAgeMin);
                Jouet unJouet = new Jouet(pId, pLibelle, uneCategorie, uneTrancheA, pQtte);
                pJouetList.Add(unJouet);

            }
            return pJouetList;
        }

        public static int GetnbJouet(int idJouet)
        {
            seConnecter();

            SqlCommand maCommande;
            string ReqBool = "SELECT COUNT(*) AS nbJouetsAcomm FROM Enfant E JOIN Jouet J ON (E.idJouet=J.id) WHERE J.id = "+idJouet; // recupere les informations
            maCommande = new SqlCommand(ReqBool, laConnexion);
            SqlDataReader Resultat = maCommande.ExecuteReader();
            int nbAcommander =0;
            while (Resultat.Read()) //Parcours le resultat
            {
                int nbAcom = (int)Resultat["nbJouetsAcomm"];
                nbAcommander = nbAcom;
            }
            return nbAcommander;
        }

        public static int GetnbJouetTotal()
        {
            seConnecter();

            SqlCommand maCommande;
            string ReqBool = "SELECT COUNT(*) AS nbJouetsAcomm FROM Enfant WHERE idJouet IS NOT NULL"; // recupere les informations
            maCommande = new SqlCommand(ReqBool, laConnexion);
            SqlDataReader Resultat = maCommande.ExecuteReader();
            int nbAcommander = 0;
            while (Resultat.Read()) //Parcours le resultat
            {
                int nbAcom = (int)Resultat["nbJouetsAcomm"];
                nbAcommander = nbAcom;
            }
            Resultat.Close();
            return nbAcommander;
        }     
        /*
        public static Categorie GetCategorieDeJouet(int idJouet)
        {
            seConnecter();            
            SqlCommand maCommande;   
            string requeteIdentifiant = "SELECT idCategorie,C.libelle FROM Jouet J JOIN Categorie C ON (J.idCategorie = C.id) WHERE J.id=" + idJouet; // recupere les informations
            maCommande = new SqlCommand(requeteIdentifiant, laConnexion);
            SqlDataReader Resultat = maCommande.ExecuteReader();
            while (Resultat.Read()) //Parcours le resultat
            {
                int pId = (int)Resultat["idCategorie"];
                string pLibelle = (string)Resultat["libelle"];
                Categorie uneCategorie = new Categorie(pId, pLibelle);
                
                

            }
            return uneCategorie;
        }
         * */

        public static List<Categorie> ToutLesJouetsCommande()
        {
            seConnecter();
            ArrayList lesCateQtt;
            lesCateQtt = new ArrayList();
            SqlCommand maCommande;
            string requeteIdentifiant = "SELECT J.idCategorie , C.libelle AS libelleC , COUNT(E.idJouet) AS nbCom FROM Jouet J JOIN Categorie C ON (J.idCategorie = C.id) JOIN TrancheAge T ON (J.idTrancheAge=T.id) JOIN Enfant E ON (E.idJouet=J.id) GROUP BY J.idCategorie, C.libelle"; // recupere les informations
            maCommande = new SqlCommand(requeteIdentifiant, laConnexion);
            SqlDataReader Resultat = maCommande.ExecuteReader();
            while (Resultat.Read()) //Parcours le resultat
            {
                int pId = (int)Resultat["idCategorie"];
                string pLibelle = (string)Resultat["libelle"];
                int pQtte = (int)Resultat["nbCom"];

                Categorie uneCategorie = new Categorie(pId, pLibelle);

               

            }
            return lesCateQtt;
        }

    }
}
