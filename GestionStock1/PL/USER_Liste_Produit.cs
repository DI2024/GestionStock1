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
using Microsoft.Reporting.WinForms;

namespace GestionStock1.PL
{
    public partial class USER_Liste_Produit : UserControl
    {
        private static USER_Liste_Produit UserProduit;
        private DbStockContext db;
        //creer un instance pour le usercontrole
        public static USER_Liste_Produit Instance
        {
            get
            {
                if (UserProduit == null)
                {
                    UserProduit = new USER_Liste_Produit();
                }
                return UserProduit;
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
            produit PR = new produit();
            PL.FRM_Ajouter_Modifier_Produit frmproduit = new PL.FRM_Ajouter_Modifier_Produit(this);

            if (SelectVerif() != null)
            {
                MessageBox.Show(SelectVerif(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmproduit.lblTitre.Text = "Modifier Produit";
                frmproduit.btnactualiserP.Visible = false;
                for (int i = 0; i < dvgproduit.Rows.Count; i++) //verifier la ligne selectionné
                {
                    if ((bool)dvgproduit.Rows[i].Cells[0].Value == true) //si la ligne est selectionné
                    {
                        int MYIDSELECT = (int)dvgproduit.Rows[i].Cells[1].Value; //MYIDSELECT =id de ligne selectionner
                        PR = db.produits.SingleOrDefault(s => s.Id_produit == MYIDSELECT);//verifier si id de produit = id selectionner dans le tableau 
                        if (PR != null) //si existe
                        {
                            frmproduit.comboCategorie.Text = dvgproduit.Rows[i].Cells[5].Value.ToString();
                            frmproduit.txtnomP.Text = dvgproduit.Rows[i].Cells[2].Value.ToString();
                            frmproduit.txtQuantite.Text = dvgproduit.Rows[i].Cells[3].Value.ToString();
                            frmproduit.txtPrix.Text = dvgproduit.Rows[i].Cells[4].Value.ToString();
                            frmproduit.IDPRODUIT = (int)dvgproduit.Rows[i].Cells[1].Value;
                            //afficher image pour modifier
                            MemoryStream MS = new MemoryStream(PR.Image_produit); //pour convertir image et afficher dans picbox
                            frmproduit.PicProduit.Image= Image.FromStream(MS);

                        }
                        
                        
                    }
                }
                frmproduit.ShowDialog();
            }
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

        private void btnsupprimerproduit_Click(object sender, EventArgs e)
        {
            if (SelectVerif()=="Selectionner Un Produit")
            {
                MessageBox.Show(SelectVerif(), "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult DR = MessageBox.Show("Voulez-vous vraiment supprimez ce produit?","Suppression",MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question);
                if (DR==DialogResult.Yes)
                {
                    //verifier combien de ligne est selectionné
                    for (int i = 0; i < dvgproduit.Rows.Count; i++)
                    {
                        if ((bool)dvgproduit.Rows[i].Cells[0].Value == true) //si la ligne est selectionne
                        {
                            BL.CLS_Produit clproduit = new BL.CLS_Produit();
                            int idselect = (int)dvgproduit.Rows[i].Cells[1].Value; //id de ligne selectionne
                            clproduit.Supprimer_Produit(idselect);
                        }
                    }
                    //actualiser le tableau 
                    Actualiserdvg();
                    MessageBox.Show("Produit Supprimé avec succés ", "Suppression",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {
                    MessageBox.Show("Suppression annulé", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
            }

        }

        private void txtrecherche_TextChanged(object sender, EventArgs e)
        {
            db = new DbStockContext();
            var listerecherche = db.produits.ToList(); //liste de recherche = liste de clients
           //recherche seulement par nom 
                        listerecherche = listerecherche.Where(s => s.Nom_produit.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList(); 
                        //stringcomparison.currentcultureignorecase = si maj ou mins
                        //!=-1 exist dans la bd 

            //vider le tableau
            dvgproduit.Rows.Clear();
            //ajouter listerecherche dans le tableau client
            categorie cat = new categorie();
            foreach (var L in listerecherche)
            {
                cat = db.categories.SingleOrDefault(s => s.Id_categorie == L.Id_categorie); //pour afficher le nom de categorie
                dvgproduit.Rows.Add(false, L.Id_produit, L.Nom_produit,L.Quantite_produit,L.Prix_produit,cat.Nom_categorie) ;
            }
        }

        private void btnimprimerselect_Click(object sender, EventArgs e)
        {
            db = new DbStockContext();
            int idselect=0;
            string Nomcategorie = null;
            RAP.FRM_RAPPORT frmrpt = new RAP.FRM_RAPPORT();
            produit PR = new produit();
            if (SelectVerif()!= null)
            {
                MessageBox.Show(SelectVerif(), "Imprimer Produit", MessageBoxButtons.OK,MessageBoxIcon.Error); //verifier si l'utilisateur a coché plusieur ligne 

            }
            else
            {
                for (int i = 0; i < dvgproduit.Rows.Count; i++)
                {
                    if ((bool)dvgproduit.Rows[i].Cells[0].Value==true)//si ligne est coché
                    {
                        idselect = (int)dvgproduit.Rows[i].Cells[1].Value; //id de ligne selectionne 
                        Nomcategorie = dvgproduit.Rows[i].Cells[5].Value.ToString();//nom de categorie
                    }
                }
                ///////////////////////////////////
                PR = db.produits.SingleOrDefault(s=>s.Id_produit == idselect);
                if (PR == null) //si produit existe
                {
                    //donner le rapport
                    frmrpt.RPAffchier.LocalReport.ReportEmbeddedResource = "GestionStock1.RAP.RPT_Produit.rdlc"; //chemin de rapport
                    //ajouter using microsoft.reporting.winform
                    ReportParameter Pcategorie = new ReportParameter("RPCategorie", Nomcategorie);//nom de categorie
                    ReportParameter PNom = new ReportParameter("RPNom",PR.Nom_produit);//nom de produit
                    ReportParameter Pquantite = new ReportParameter("RPQuantite",PR.Quantite_produit);//Quantite
                    ReportParameter PPrix = new ReportParameter("RPPrix",PR.Prix_produit);//Prix

                    //image de produit
                    string ImageString = Convert.ToBase64String(PR.Image_produit);
                    ReportParameter Pimage = new ReportParameter("RPImage", ImageString);//image doit etre convertit en string base64
                    //sauvegarder les nouveaux paramettre dans le nouveau rapport 
                    frmrpt.RPAffchier.LocalReport.SetParameters(new ReportParameter[] { Pcategorie, PNom, Pquantite, PPrix, Pimage });
                    frmrpt.RPAffchier.RefreshReport();
                    frmrpt.ShowDialog();//afficher formulaire de rapport

                }
            }
        }
    }
}
