using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock1.BL
{
    internal class CLS_Produit
    {
        private DbStockContext db = new DbStockContext();
        private produit PR;
        public bool Ajouter_Produit(string NomP, string Qantite, string Prix, byte[] imageP, int idcategorie)//format byte pour sauvgarder dans la base de donnee
        {
            PR = new produit();
            PR.Nom_produit = NomP;
            PR.Quantite_produit = Qantite;
            PR.Prix_produit = Prix;
            PR.Image_produit = imageP;
            PR.Id_categorie = idcategorie;
            //verifier si le nom du produits deja existe
            if (db.produits.SingleOrDefault(a => a.Nom_produit == NomP) == null) //s'il n'exixste pas
            {
                db.produits.Add(PR);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        //modifier Produit 
        public void Modifier_Produit(int IDP,string NomP, string Qantite, string Prix, byte[] imageP, int idcategorie)
        {
            PR= new produit();
            PR = db.produits.SingleOrDefault(s => s.Id_produit == IDP); //si id de produit = mon id 
            if (PR!=null) // s'il existe
            {
                PR.Nom_produit = NomP;
                PR.Quantite_produit= Qantite;
                PR.Prix_produit= Prix;
                PR.Image_produit= imageP;
                PR.Id_categorie= idcategorie;
                db.SaveChanges();
            }
        }

        //Supprimer Produit 
        public void Supprimer_Produit(int id)
        {
            PR = new produit();
            PR = db.produits.SingleOrDefault(s=>s.Id_produit == id);
            if (PR!=null) 
            {
                db.produits.Remove(PR);
                db.SaveChanges() ;
            }
        }
    }
}