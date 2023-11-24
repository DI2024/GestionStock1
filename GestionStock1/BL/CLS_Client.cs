using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock1.BL
{
    internal class CLS_Client
    {
        private DbStockContext db = new DbStockContext();
        private client C;//table client 

         //pour ajouter client dans db 

        public bool Ajouter_Client( string Nom, string Prenom, string Adresse, string Telephone , string Email , string Pays , string Ville)
        {
            C = new client(); //nouveau client 
            C.Nom_client=Nom;
            C.Prenom_client=Prenom;
            C.Adresse_client=Adresse;
            C.Telephonne_client=Telephone;
            C.Email_client=Email;
            C.Pays_client=Pays;
            C.Ville_client=Ville;
            //verifier si le nom et le prenom est deja dans la base donnee 
            if (db.clients.SingleOrDefault(s=>s.Nom_client==Nom && C.Prenom_client==Prenom)==null) //si n'existe pas 
            {
                db.clients.Add(C);
                db.SaveChanges();//enregistrer dans la base de donnee
                return true;
            }
            else //si existe dans la base donnee 
            {
                return false;
            }

        }
        
        //pour modifier client dans db 
        public void Modifier_Client(int id, string Nom, string Prenom, string Adresse, string Telephone, string Email, string Pays, string Ville)
        {
            C=new client();
            C=db.clients.SingleOrDefault(s=>s.Id_client==id); //verifier si id existe
            if (C!=null) //existe
            {
                C.Nom_client = Nom;
                C.Prenom_client = Prenom;
                C.Adresse_client=Adresse;
                C.Telephonne_client = Telephone;   
                C.Email_client=Email;
                C.Pays_client=Pays;
                C.Ville_client=Ville;
                db.SaveChanges() ; //save the new information dans le base donnee
            }
        }
        
        //function supprimer
        public void supprimer_Client(int id)
        {
            C = new client();
            C = db.clients.SingleOrDefault(s => s.Id_client == id);

            if (C!=null)
            {
                db.clients.Remove(C);//pour supprimer le Client 
                db.SaveChanges();
            }

        }



    }
}
