using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
        //verifier combien de ligne est selectionne
        public string SelectVerif()
        {
            int Nombreligneselect = 0;
            for (int i = 0; i < dvgproduit.Rows.Count; i++)
            {
                if ((bool)dvgproduit.Rows[i].Cells[0].Value) //si ligne est selectionee
                {
                    Nombreligneselect++;
                }
            }
            if (Nombreligneselect == 0)
            {
                return "Selectionner Produit";
            }
            if (Nombreligneselect > 1)
            {
                return "Selectionner seulement 1 seul Produit";
            }
            return null;

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

        private void btnafficherphotoproduit_Click(object sender, EventArgs e)
        {
            produit PR = new produit();
            if(SelectVerif()!=null)
            {
                MessageBox.Show(SelectVerif(),"Selectionner",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for(int i = 0;i<dvgproduit.Rows.Count;i++) //verifier la ligne selectionné
                {
                    if ((bool)dvgproduit.Rows[i].Cells[0].Value==true) //si la ligne est selectionné
                    {
                        int MYIDSELECT =(int) dvgproduit.Rows[i].Cells[1].Value; //MYIDSELECT =id de ligne selectionner
                        PR = db.produits.SingleOrDefault(s => s.Id_produit == MYIDSELECT);//verifier si id de produit = id selectionner dans le tableau 
                        if (PR!=null) //si existe
                        {
                            FRM_Photo_Produit frmP = new FRM_Photo_Produit();
                            //declaration system io 
                            MemoryStream MS=new MemoryStream(PR.Image_produit); //pour convertir image et afficher dans picbox
                            frmP.ProduitImage.Image=Image.FromStream(MS);
                            frmP.ProduitNom.Text = dvgproduit.Rows[i].Cells[2].Value.ToString();
                            //afficher formulaire
                            frmP.ShowDialog();
                        }
                    }
                }
            }
        }
    }
}
