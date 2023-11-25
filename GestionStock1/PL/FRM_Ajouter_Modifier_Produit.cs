using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GestionStock1.PL
{
    public partial class FRM_Ajouter_Modifier_Produit : Form
    {
        private DbStockContext db;
        private UserControl userProduit;
        public FRM_Ajouter_Modifier_Produit(UserControl User)
        {
            InitializeComponent();
            db = new DbStockContext();
            this.userProduit = User;
            //afficher les categorie dans combobox
            comboCategorie.DataSource = db.categories.ToList();
            //pour filtrer seulement le nom des categorie
            comboCategorie.DisplayMember = "Nom_categorie";
            comboCategorie.ValueMember = "Id_categorie";
            
        }
        //les chomp obligatoire
        string testobligatoire()
        {

            if (txtnomP.Text == "" || txtnomP.Text == "Nom Produit")
            {
                return "Entrer le Nom du Produit";
            }
            if (txtQuantite.Text == "" || txtQuantite.Text == "Quantite")
            {
                return "Entrer la Quantite du Produit";
            }
            if (txtPrix.Text == "" || txtPrix.Text == "Prix")
            {
                return "Entrer le Prix du Produit";
            }
            if (PicProduit == null)
            {
                return "Entrer l'image du Produit";

            }
            if (comboCategorie.Text == "" )
            {
                return "Entrer la Categorie du Produit";
            }
            return null;
        }

            private void txtnomP_Enter(object sender, EventArgs e)
        {
            if (txtnomP.Text =="Nom Produit")
            {
                txtnomP.Text = "";
                txtnomP.ForeColor=Color.White;
            }
        }

        private void txtnomP_Leave(object sender, EventArgs e)
        {
            if (txtnomP.Text == "")
            {
                txtnomP.Text = "Nom Produit";
                txtnomP.ForeColor = Color.Silver;
            }
        }

        private void txtQuantite_Enter(object sender, EventArgs e)
        {
            if (txtQuantite.Text == "Quantite")
            {
                txtQuantite.Text = "";
                txtQuantite.ForeColor = Color.White;
            }
        }

        private void txtQuantite_Leave(object sender, EventArgs e)
        {
            if (txtQuantite.Text == "")
            {
                txtQuantite.Text = "Quantite";
                txtQuantite.ForeColor = Color.Silver;
            }
        }

        private void txtPrix_Enter(object sender, EventArgs e)
        {
            if (txtPrix.Text == "Prix")
            {
                txtPrix.Text = "";
                txtPrix.ForeColor = Color.White;
            }
        }

        private void txtPrix_Leave(object sender, EventArgs e)
        {
            if (txtPrix.Text == "")
            {
                txtPrix.Text = "Prix";
                txtPrix.ForeColor = Color.Silver;
            }
        }

        private void FRM_Ajouter_Modifier_Produit_Load(object sender, EventArgs e)
        {

        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPaarcourir_Click(object sender, EventArgs e)
        {
            //afficher les ficheier image 
            OpenFileDialog Op = new OpenFileDialog();
            Op.Filter = "|*.JPG;*.PNG;*.JPEG;*.GIF;*.BMP;"; //pour afficher seulement les image 
            if (Op.ShowDialog()==DialogResult.OK)
            {
                PicProduit.Image=Image.FromFile(Op.FileName);
            }
        }

        private void btnactualiserP_Click(object sender, EventArgs e)
        {
            //vider le formulaire 
            txtnomP.Text = "Nom Produit";
            txtnomP.ForeColor = Color.Silver;
            txtQuantite.Text = "Quantite";
            txtQuantite.ForeColor = Color.Silver;
            txtPrix.Text = "Prix";
            txtPrix.ForeColor = Color.Silver;
            comboCategorie.Text = "";
            PicProduit.Image = null;

        }

        private void txtQuantite_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textbox numeric
            if (e.KeyChar < 48 || e.KeyChar > 57) //code asci des num
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void txtPrix_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textbox numeric
            if (e.KeyChar < 48 || e.KeyChar > 57) //code asci des num
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void btnenregistrerP_Click(object sender, EventArgs e)
        {
            if (testobligatoire()!=null)
            {
                MessageBox.Show(testobligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(lblTitre.Text=="Ajouter Produit")
                {
                    BL.CLS_Produit clproduit = new BL.CLS_Produit();
                    //convertir image to format byte
                    //ajouter using system io 
                    MemoryStream MR = new MemoryStream();
                    PicProduit.Image.Save(MR, PicProduit.Image.RawFormat);
                    byte[] byteimage = MR.ToArray(); //convertir image en format byte
                    if (clproduit.Ajouter_Produit(txtnomP.Text, txtQuantite.Text, txtPrix.Text, byteimage,Convert.ToInt32(comboCategorie.SelectedValue))==true)
                    {
                        MessageBox.Show("Produit ajouté avec succes","Ajouter",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (userProduit as USER_Liste_Produit).Actualiserdvg();
                    }
                    else
                    {
                        MessageBox.Show("Produit déja existe", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

        }
    }
}
