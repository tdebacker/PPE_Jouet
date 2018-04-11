using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Windows.Forms;

namespace PTR_PPE_Jouet
{
    class Passerelle
    {
        private static SqlConnection laConnexion = null;

        private static bool seConnecter()
        {
            if (laConnexion == null || laConnexion.State.ToString() != "Open")
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

            string requeteInfoResponsable = "SELECT estResponsable FROM Employe WHERE mail = '" + mail + "'";

            maCommande = new SqlCommand(requeteInfoResponsable, laConnexion);

            bool Resultat = (bool)maCommande.ExecuteScalar();

            return Resultat;

        }

        public static int recupIdEmploye(string mail,string mdp)
        {
            seConnecter();

            SqlCommand maCommande;

            string requeteInfoId = "SELECT id FROM Employe WHERE mail = '" + mail + "'"+"AND mdp"+"= '" + mdp + "'";

            maCommande = new SqlCommand(requeteInfoId, laConnexion);

            int Resultat = (int)maCommande.ExecuteScalar();

            return Resultat;

        }


        public static List<Enfant> EnfantsDeEmploye(int idEmploye)
        {
            
            seConnecter();
            List<Enfant> lesEnfants = new List<Enfant>();
            SqlCommand maCommande;
            string requeteIdentifiant = "SELECT E.id, E.nom, E.prenom ,E.age, E.idJouet, E.idEmploye, "     //enfant
            +"P.nom as empNom, P.prenom as empPrenom, P.numAdr, P.rue, P.ville, P.cp, P.mail, P.mdp, P.estResponsable, P.aValide, "      //employé
            +"J.libelle, J.idCategorie, J.idTrancheAge, "     //jouet
            +"T.ageMin, "     //tranche age
            +"C.libelle "     //catégorie
            +"FROM Enfant E JOIN Employe P ON (E.idEmploye=P.id) JOIN Jouet J ON(E.idJouet=J.id) "
            +"JOIN Categorie C on C.id = J.idCategorie JOIN TrancheAge T on T.id = J.idTrancheAge "
            +"WHERE idEmploye ="+idEmploye; // recupere les informations
            maCommande = new SqlCommand(requeteIdentifiant, laConnexion);
            SqlDataReader Resultat = maCommande.ExecuteReader();
           
            while (Resultat.Read()) //Parcours le resultat
            {
                //données enfant
                int pIdE = (int)Resultat["id"];
                string pNom = (string)Resultat["nom"];
                string pPrenom = (string)Resultat["prenom"];
                int pAge = (int)Resultat["age"];
                int pIdJ =(int)Resultat["idJouet"];
                int pIdEm =(int)Resultat["idEmploye"];

                //données employé
                string pNomEm = (string)Resultat["empNom"];
                string pPrenomEm = (string)Resultat["empPrenom"];
                string pnumAdre = (string)Resultat["numAdr"];
                string pRue = (string)Resultat["rue"];
                string pVille = (string)Resultat["ville"];
                string pCp = (string)Resultat["cp"];
                string pMail = (string)Resultat["mail"];
                string pMdp = (string)Resultat["mdp"];
                bool pEstRes = (bool)Resultat["estResponsable"];
                bool pEstValide = (bool)Resultat["aValide"];

                //données jouet
                string pLibelleJ = (string)Resultat["libelle"];
                int pIdCat = (int)Resultat["idCategorie"];
                int pIdTrancheAge = (int)Resultat["idTrancheAge"];

                //données tranche age
                int pAgeMin = (int)Resultat["ageMin"];

                //données catégorie
                string pLibelleCat = (string)Resultat["libelle"];
                
                Personne unePersonne = new Personne(pIdEm, pNomEm, pPrenomEm, pnumAdre, pRue, pVille, pCp, pMail, pMdp, pEstRes, pEstValide);
                Categorie uneCat = new Categorie(pIdCat, pLibelleCat);
                TrancheAge uneTrancheAge = new TrancheAge(pIdTrancheAge, pAgeMin);
                Jouet unJouet = new Jouet(pIdJ, pLibelleJ, uneCat, uneTrancheAge);
                Enfant unEnfant = new Enfant(pIdE, pNom, pPrenom, pAge, unePersonne, unJouet);

                lesEnfants.Add(unEnfant);

            }
            Resultat.Close();

            return lesEnfants;
        }

        
        
        public static List<Jouet> ToutLesJouets(int pAge)
        {
            seConnecter();
            List<Jouet> JouetList = new List<Jouet>();
            SqlCommand maCommande;
            string requeteIdentifiant = "SELECT DISTINCT J.id , J.libelle , J.idCategorie , J.idTrancheAge , C.libelle as cLibelle , T.ageMin " +
            "FROM Jouet J LEFT JOIN Categorie C " +
            "ON (J.idCategorie = C.id) LEFT JOIN TrancheAge T " +
            "ON (J.idTrancheAge=T.id) LEFT JOIN Enfant E " +
            "ON (E.idJouet = J.id) " +
            "WHERE T.ageMin <= " + pAge;
            maCommande = new SqlCommand(requeteIdentifiant, laConnexion);
            SqlDataReader Resultat = maCommande.ExecuteReader();
            while (Resultat.Read()) //Parcours le resultat
            {
                int pId = (int)Resultat["id"];
                string pLibelle = (string)Resultat["libelle"];
                int pIdC = (int)Resultat["idCategorie"];
                int pIdT = (int)Resultat["idTrancheAge"];
                string pLibelleC = (string)Resultat["cLibelle"];
                int pAgeMin = (int)Resultat["ageMin"];

                Categorie uneCategorie = new Categorie(pIdC, pLibelleC);
                TrancheAge uneTrancheA = new TrancheAge(pIdT, pAgeMin);
                Jouet unJouet = new Jouet(pId, pLibelle, uneCategorie, uneTrancheA);
                JouetList.Add(unJouet);

            }
            Resultat.Close();
            return JouetList;     
        }

        public static int updateJouet(int idJouet, int idEnfant)
        {
            seConnecter();
            SqlCommand commande;
            int resultat = 0;
            string requete = "UPDATE Enfant "
                + "SET idJouet = " + idJouet + " "
                + "WHERE id = " + idEnfant;

            commande = new SqlCommand(requete, laConnexion);
            try
            {
                resultat = commande.ExecuteNonQuery();
            }
            catch(InvalidOperationException e)
            {
                MessageBox.Show("Erreur! " + e.Message);
            }
            

            return resultat;
        }

        public static List<Jouet> ToutLesJouetsCommande()
        {
            seConnecter();
            List<Jouet> pJouetList;
            pJouetList = new List<Jouet>();
            SqlCommand maCommande;
            string requeteIdentifiant = "SELECT J.id , J.libelle , J.idCategorie , J.idTrancheAge , C.libelle AS libelleC , T.ageMin , COUNT(E.idJouet) AS nbCom FROM Jouet J JOIN Categorie C ON (J.idCategorie = C.id) JOIN TrancheAge T ON (J.idTrancheAge=T.id) JOIN Enfant E ON (E.idJouet=J.id) GROUP BY E.idJouet,J.id , J.libelle , J.idCategorie , J.idTrancheAge , C.libelle , T.ageMin HAVING J.id <> 12"; // recupere les informations
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
            Resultat.Close();
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



        public static List<Categorie> ToutLesJouetsCat()
        {
            seConnecter();
            List<Categorie> lesCateQtt;
            lesCateQtt = new List<Categorie>();
            SqlCommand maCommande2;
            string requeteIdentifiant = "SELECT J.idCategorie , C.libelle AS libelleC , COUNT(E.idJouet) AS nbCom "
            +"FROM Jouet J JOIN Categorie C ON (J.idCategorie = C.id) JOIN TrancheAge T ON (J.idTrancheAge=T.id) JOIN Enfant E ON (E.idJouet=J.id) "
            +"GROUP BY J.idCategorie, C.libelle HAVING J.idCategorie <> 6 "; // recupere les informations
            maCommande2 = new SqlCommand(requeteIdentifiant, laConnexion);
            SqlDataReader Resultat = maCommande2.ExecuteReader();
            while (Resultat.Read()) //Parcours le resultat
            {
                int pId = (int)Resultat["idCategorie"];
                string pLibelle = (string)Resultat["libelleC"];
                int pQtte = (int)Resultat["nbCom"];
                Categorie uneCategorie = new Categorie(pId, pLibelle, pQtte);
                lesCateQtt.Add(uneCategorie);
            }
            Resultat.Close();
            return lesCateQtt;
        }


        public static Jouet getLeJouet(int idEnfant)
        {
            seConnecter();
            Jouet unJouet = null;
            SqlCommand maCommande;
            string requete = "select j.id, j.libelle, idCategorie, idTrancheAge, c.libelle as cLibelle, ageMin  "
            + "from jouet j join enfant e on j.id = e.idJouet "
            +"join categorie c on c.id = j.idCategorie join trancheAge ta on ta.id = j.idTrancheAge  "
            + "where e.id = " + idEnfant;
            maCommande = new SqlCommand(requete, laConnexion);
            SqlDataReader Resultat = maCommande.ExecuteReader();
            while(Resultat.Read())
            {
                int id = (int)Resultat["id"];
                string libelle = (string)Resultat["libelle"];
                int idCat = (int)Resultat["idCategorie"];
                int idTrancheAge = (int)Resultat["idTrancheAge"];
                string cLibelle = (string)Resultat["cLibelle"];
                int ageMin = (int)Resultat["ageMin"];

                Categorie uneCat = new Categorie(idCat, cLibelle);
                TrancheAge uneTA = new TrancheAge(idTrancheAge, ageMin);
                unJouet = new Jouet(id, libelle, uneCat, uneTA);
            }
            Resultat.Close();
            seDeconnecter();

            return unJouet;
        }



        public static bool aValide(int idEmp)
        {
            seConnecter();
            SqlCommand maCommande;
            bool valider = true;
            string requete = "SELECT aValide "
                + "FROM Employe "
                + "WHERE id = " + idEmp;
            maCommande = new SqlCommand(requete, laConnexion);
            SqlDataReader Resultat = maCommande.ExecuteReader();
            while (Resultat.Read())
            {
                valider = (bool)Resultat["aValide"];
            }


            Resultat.Close();
            seDeconnecter();

            return valider;
        }

        public static int updateAValide(int idEmp)
        {
            seConnecter();
            SqlCommand commande;
            int resultat = 0;
            string requete = "UPDATE Employe "
                + "SET aValide = 1 "
                + "WHERE id = " + idEmp;

            commande = new SqlCommand(requete, laConnexion);
            try
            {
                resultat = commande.ExecuteNonQuery();
            }
            catch (InvalidOperationException e)
            {

            }


            return resultat;
        }


        /**************************/

        public static List<Personne> lesEmployes()
        {
            seConnecter();
            List<Personne> LesPers;
            LesPers = new List<Personne>();
            SqlCommand maCommande2;
            string requeteIdentifiant = "SELECT id,nom,prenom,numAdr,rue,ville,cp,mail,mdp,estResponsable,aValide from PERSONNE WHERE estResponsable = 0 ;"; // recupere les informations
            maCommande2 = new SqlCommand(requeteIdentifiant, laConnexion);
            SqlDataReader Resultat = maCommande2.ExecuteReader();
            while (Resultat.Read()) //Parcours le resultat
            {

                int pId = (int)Resultat["id"];
                string pNom = (string)Resultat["nom"];
                string pPrenom = (string)Resultat["prenom"];
                string pNumAdr = (string)Resultat["numAdr"];
                string rue = (string)Resultat["rue"];
                string ville = (string)Resultat["ville"];
                string cp = (string)Resultat["cp"];
                string mail = (string)Resultat["mail"];
                string mdp = (string)Resultat["mdp"];
                bool pEstResp = (bool)Resultat["estResponsable"];
                bool pEstValide = (bool)Resultat["aValide"];


                Personne uneP = new Personne(pId, pNom, pPrenom, pNumAdr, rue, ville, cp, mail, mdp, pEstResp, pEstValide);

                LesPers.Add(uneP);



            }
            Resultat.Close();
            return LesPers;
        }

        public static Personne getLaPersonne(int idPersonne)
        {
            seConnecter();
            SqlCommand maCommande;
            Personne uneP = null;

            string requete = "SELECT id ,nom ,prenom, numAdr , rue , ville , cp , mail , mdp FROM personne WHERE id =" + idPersonne;
            maCommande = new SqlCommand(requete, laConnexion);
            SqlDataReader Resultat = maCommande.ExecuteReader();
            while (Resultat.Read())
            {
                int pId = (int)Resultat["id"];
                string pNom = (string)Resultat["nom"];
                string pPrenom = (string)Resultat["prenom"];

                string pNumAdr = (string)Resultat["numAdr"];
                string rue = (string)Resultat["rue"];
                string ville = (string)Resultat["ville"];
                string cp = (string)Resultat["cp"];
                string mail = (string)Resultat["mail"];
                string mdp = (string)Resultat["mdp"];
                bool pEstResp = (bool)Resultat["estResponsable"];
                bool pEstValide = (bool)Resultat["aValide"];

                uneP = new Personne(pId, pNom, pPrenom, pNumAdr, rue, ville, cp, mail, mdp, pEstResp, pEstValide);

            }
            Resultat.Close();
            seDeconnecter();

            return uneP;
        }

        public static int updateEmploye(int id, string numAdr, string nomEm, string prenomEm, string emailEm, string adrRueEm, string villeEm, string cpEm)
        {
            seConnecter();
            SqlCommand commande;
            int resultat = 0;
            string requete = "UPDATE Employe "
                + "  SET nom = '" + nomEm + "' "
                + ", prenom = '" + prenomEm + "' "
                + ", numAdr = '" + numAdr + "' "
                + ", rue = '" + adrRueEm + "' "
                + ", ville = '" + villeEm + "' "
                + ", cp = '" + cpEm + "' "
                + ", mail = '" + emailEm + "' "
                 + " WHERE id = " + id;

            commande = new SqlCommand(requete, laConnexion);
            try
            {
                resultat = commande.ExecuteNonQuery();
            }
            catch (InvalidOperationException e)
            {

            }


            return resultat;
        }

        public static int updateEnfant(int id, string nomEnf, string prenomEnf, int AgeEnf)
        {
            seConnecter();
            SqlCommand commande;
            int resultat = 0;
            string requete = "UPDATE Enfant "
                + "  SET nom = '" + nomEnf + "' "
                + ", prenom = '" + prenomEnf + "' "
                + ", age = " + AgeEnf + " "
                 + " WHERE id = " + id;

            commande = new SqlCommand(requete, laConnexion);
            try
            {
                resultat = commande.ExecuteNonQuery();
            }
            catch (InvalidOperationException e)
            {

            }


            return resultat;
        }

        public static int AjoutEnfant(string nomEnf, string prenomEnf, int AgeEnf, int idEmpl)
        {
            seConnecter();
            SqlCommand commande;
            int resultat = 0;
            string requete = "INSERT INTO Enfant (nom,prenom,age,idJouet,idEmploye) "
                + "  VALUES ('" + nomEnf + "' "
                + ",'" + prenomEnf + "' "
                + "," + AgeEnf + " "
                + ",12 "
                + "," + idEmpl + " ) ;";


            commande = new SqlCommand(requete, laConnexion);
            try
            {
                resultat = commande.ExecuteNonQuery();
            }
            catch (InvalidOperationException e)
            {

            }


            return resultat;
        }

        public static int deleteEnfant(int id)
        {
            seConnecter();
            SqlCommand commande;
            int resultat = 0;
            string requete = "DELETE FROM Enfant WHERE id =" + id;

            commande = new SqlCommand(requete, laConnexion);
            try
            {
                resultat = commande.ExecuteNonQuery();
            }
            catch (InvalidOperationException e)
            {

            }


            return resultat;
        }


        public static int AjoutEmploye(string nomEmp, string prenomEmp, string numAdr, string rue, string ville, string cp, string mail)
        {
            seConnecter();
            SqlCommand commande;
            int resultat = 0;
            string requete = "INSERT INTO Employe (nom, prenom, numAdr, rue, ville, cp, mail, estResponsable, aValide) "
                + "  VALUES ('" + nomEmp + "' "
                + ",'" + prenomEmp + "' "
                + ",'" + numAdr + "' "
                + ",'" + rue + "' "
                + ",'" + ville + "' "
                + ",'" + cp + "' "
                + ",'" + mail + "' "
                + ", 0, 0 ) ;";


            commande = new SqlCommand(requete, laConnexion);
            try
            {
                resultat = commande.ExecuteNonQuery();
            }
            catch (InvalidOperationException e)
            {

            }


            return resultat;
        }
    }
}
