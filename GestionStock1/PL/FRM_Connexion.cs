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
    public partial class FRM_Connexion : Form
    {
        private DbStockContext db;
        private Form frmmenu;
        //classe connexion
        BL.CLS_connexion C = new BL.CLS_connexion();
        public FRM_Connexion(Form Menu)
        {
            InitializeComponent();
            this.frmmenu = Menu;
            //initialisez la bade de donnee
            db = new DbStockContext();

        }
        string testObligatoire()
        {
            if (txtn.Text == "" || txtn.Text == "Nom d'utilisateur")
            {
                return "Enter votre nom";
            }
            if (txtmdp.Text == "" || txtmdp.Text == "Mot De Passe")
            {
                return "Enter votre Mot de Passe";
            }
            return null;
        }


        private void FRM_Connexion_Load_1(object sender, EventArgs e)
        {

        }

        private void txtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (testObligatoire() == null)
            {
                if (C.ConnexionValider(db, txtn.Text, txtmdp.Text) == true) //utilisateur existe
                {
                    MessageBox.Show("Connexion a réussi", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (frmmenu as FRM_MENU).activerform();
                    this.Close();//quitter formulaire connexion
                }
                else //n'existe pas 
                {
                    MessageBox.Show("Connexion a echoué", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show(testObligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtn_Enter(object sender, EventArgs e)
        {
            if (txtn.Text == "Nom d'utilisateur")
            {
                txtn.Text = "";

                txtn.ForeColor = Color.WhiteSmoke;


            }
        }

        private void txtn_Leave(object sender, EventArgs e)
        {
            if (txtn.Text == "")
            {
                txtn.Text = "Nom d'utilisateur";
                txtn.ForeColor = Color.Silver;

            }
        }

        private void txtmdp_Enter(object sender, EventArgs e)
        {
            if (txtmdp.Text == "Mot De Passe")
            {
                txtmdp.Text = "";
                txtmdp.UseSystemPasswordChar = false;
                txtmdp.PasswordChar = '*';
                txtmdp.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtmdp_Leave(object sender, EventArgs e)
        {
            if (txtmdp.Text == "")
            {

                txtmdp.Text = "Mot De Passe";
                txtmdp.UseSystemPasswordChar = true;
                txtmdp.ForeColor = Color.Silver;

            }
        }
    }
}
