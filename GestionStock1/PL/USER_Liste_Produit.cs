using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock1.PL
{
    public partial class USER_Liste_Produit : UserControl
    {
        private static USER_Liste_Produit UserClient;
        private DbStockContext db;
        //creer un instance pour le usercontrole
        public static USER_Liste_Produit Instance
        {
            get
            {
                if (UserClient == null)
                {
                    UserClient = new USER_Liste_Produit();
                }
                return UserClient;
            }
        }

        public USER_Liste_Produit()
        {
            InitializeComponent();
            db = new DbStockContext();
        }
        //actualiser le tableau
        public void Actualiserdvg()
        {
            db=new DbStockContext();
            dvgproduit.Rows.Clear();
            //pour afficher le nom de categorie a partir de idcategorie
            categorie Cat=new categorie();
            foreach (var Lis in db.produits)
            {
                Cat = db.categories.SingleOrDefault(s => s.Id_categorie==Lis.Id_categorie); //si idcategorie dans produit = idcategorie dans categorie
                if (Cat!=null) //s'il existe
                {
                    dvgproduit.Rows.Add(false, Lis.Id_produit, Lis.Nom_produit, Lis.Quantite_produit, Lis.Prix_produit, Cat.Nom_categorie);//pour afficher le nom du categorie 
                }
            }
        }

        private void USER_Liste_Produit_Load(object sender, EventArgs e)
        {
            Actualiserdvg();
        }

        private void txtrecherche_Enter(object sender, EventArgs e)
        {
            if (txtrecherche.Text == "Recherche")
            {
                txtrecherche.Text = "";
                txtrecherche.ForeColor = Color.Black;

            }
        }

        private void btnajouterproduit_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajouter_Modifier_Produit frmProduit = new PL.FRM_Ajouter_Modifier_Produit(this);
            frmProduit.ShowDialog();
        }

        private void btnmodifierproduit_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajouter_Modifier_Produit frmproduit = new PL.FRM_Ajouter_Modifier_Produit(this);
            frmproduit.lblTitre.Text = "Modifier Produit";
            frmproduit.btnactualiserP.Visible = false;
            frmproduit.ShowDialog();
        }
    }
}
