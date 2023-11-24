using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock1.BL
{
    internal class CLS_connexion
    {
        //pour verifier la cnx
        public bool ConnexionValider(DbStockContext db, string Nom, string Mot_de_passe)
        {
            utilisateur U = new utilisateur(); //table utilisateur
            U.NomUtilisateur = Nom;
            U.Mot_de_passe = Mot_de_passe;
            if (db.utilisateurs.SingleOrDefault(s => s.NomUtilisateur == Nom && s.Mot_de_passe == Mot_de_passe) != null)//si le nom et le mdp existe dans la base de donne 
            {
                return true;
            }
            else //s'il n'existe pas 
            {
                return false;

            }
        }
    }
}
