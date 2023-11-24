using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Diagnostics.Eventing.Reader;

namespace GestionStock1.PL
{
    public partial class FRM_Ajouter_Modifier_Client : Form
    {
        private UserControl usclient;
        public FRM_Ajouter_Modifier_Client(UserControl userC)
        {
            InitializeComponent();
            this.usclient = userC;
        }
        //les comp obligatoire
        string testobligatoire()
        {
            if (txtnom.Text=="" || txtnom.Text=="Nom de Client")
            {
                return "Entrer le Nom du Client";
            }
            if (txtprenom.Text == "" || txtprenom.Text == "Prenom de Client")
            {
                return "Entrer le Prenom du Client";
            }
            if (txtadresse.Text == "" || txtadresse.Text == "Adresse de Client")
            {
                return "Entrer le Adresse du Client";
            }
            if (txttelephone.Text == "" || txttelephone.Text == "Telephone de Client")
            {
                return "Entrer le Telephone du Client";
            }
            if (txtemail.Text == "" || txtemail.Text == "Email de Client")
            {
                return "Entrer le Email du Client";
            }
            if (txtpays.Text == "" || txtpays.Text == "Pays de Client")
            {
                return "Entrer le Pays du Client";
            }
            if (txtville.Text == "" || txtville.Text == "Ville de Client")
            {
                return "Entrer le Ville du Client";
            }
            //pour verifier si l'email est valide o non 
            if (txtemail.Text!="" || txtemail.Text!="Email de Client")
            {
                try
                {
                    new MailAddress(txtemail.Text); //pour verifier si l'email est valide o non 

                }
                catch (Exception e)
                {
                    return "Email Invalide";
                }
            }
            return null;
        }

        private void txtnom_Enter(object sender, EventArgs e)
        {
            if (txtnom.Text =="Nom de Client")
            {
                txtnom.Text = "";
                txtnom.ForeColor=Color.White;
                
            }
        }

        private void txtnom_Leave(object sender, EventArgs e)
        {
            if (txtnom.Text == "")
            {
                txtnom.Text = "Nom de Client";
                txtnom.ForeColor = Color.Silver;

            }
        }

        private void txtadresse_Enter(object sender, EventArgs e)
        {
            if(txtadresse.Text =="Adresse de Client")
            {
                txtadresse.Text = "";
                txtadresse.ForeColor = Color.White;
            }
        }

        private void txtadresse_Leave(object sender, EventArgs e)
        {
            if (txtadresse.Text == "")
            {
                txtadresse.Text = "Adresse de Client";
                txtadresse.ForeColor = Color.Silver;
            }
        }

        private void txtpays_Enter(object sender, EventArgs e)
        {
            if (txtpays.Text == "Pays de Client")
            {
                txtpays.Text = "";
                txtpays.ForeColor = Color.White;
            }
        }

        private void txtpays_Leave(object sender, EventArgs e)
        {
            if (txtpays.Text == "")
            {
                txtpays.Text = "Pays de Client";
                txtpays.ForeColor = Color.Silver;
            }
        }

        private void txtprenom_Enter(object sender, EventArgs e)
        {
            if (txtprenom.Text == "Prenom de Client")
            {
                txtprenom.Text = "";
                txtprenom.ForeColor = Color.White;
            }

        }

        private void txtprenom_Leave(object sender, EventArgs e)
        {
            if (txtprenom.Text == "")
            {
                txtprenom.Text = "Prenom de Client";
                txtprenom.ForeColor = Color.Silver;
            }
        }

        private void txttelephone_Enter(object sender, EventArgs e)
        {
            if (txttelephone.Text == "Telephone de Client")
            {
                txttelephone.Text = "";
                txttelephone.ForeColor = Color.White;
            }
        }

        private void txttelephone_Leave(object sender, EventArgs e)
        {
            if (txttelephone.Text == "")
            {
                txttelephone.Text = "Telephone de Client";
                txttelephone.ForeColor = Color.Silver;
            }
        }

        private void txtemail_Enter(object sender, EventArgs e)
        {
            if (txtemail.Text == "Email de Client")
            {
                txtemail.Text = "";
                txtemail.ForeColor = Color.White;
            }
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (txtemail.Text == "")
            {
                txtemail.Text = "Email de Client";
                txtemail.ForeColor = Color.Silver;
            }
        }

        private void txtville_Enter(object sender, EventArgs e)
        {
            if (txtville.Text == "Ville de Client")
            {
                txtville.Text = "";
                txtville.ForeColor = Color.White;
            }
        }

        private void txtville_Leave(object sender, EventArgs e)
        {
            if (txtville.Text == "")
            {
                txtville.Text = "Ville de Client";
                txtville.ForeColor = Color.Silver;
            }
        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txttelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textbox numeric
            if (e.KeyChar<48 || e.KeyChar>57) //code asci des num
            {
                e.Handled = true;
            }
            if (e.KeyChar==8)
            { 
                e.Handled = false;
            }
        }
        public int IDselect;
        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            if (testobligatoire()!=null)
            {
                MessageBox.Show(testobligatoire(), "Obligatoire",MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
            else
            if(lblTitre.Text=="Ajouter Client")
            {
               
                BL.CLS_Client clClient = new BL.CLS_Client();
                if (clClient.Ajouter_Client(txtnom.Text, txtprenom.Text, txtadresse.Text, txttelephone.Text, txtemail.Text, txtpays.Text, txtville.Text)==true)
                {
                    MessageBox.Show("Client Ajouter avec succes", "Ajoute",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    (usclient as USER_Liste_Client).Actualisedatagrid();
                }
                else
                {
                    MessageBox.Show("Nom et Prenom déja existe", "Ajoute", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
             

            }
            else //si lbltitre = modifer 
            {
                BL.CLS_Client clClient = new BL.CLS_Client();
                DialogResult R = MessageBox.Show("Voulez-vous vraiment modifier ce Client","Modification", MessageBoxButtons.YesNo,MessageBoxIcon.Question) ;
                if (R == DialogResult.Yes)
                {
                    clClient.Modifier_Client(IDselect, txtnom.Text, txtprenom.Text, txtadresse.Text, txttelephone.Text, txtemail.Text, txtpays.Text, txtville.Text);
                    //pour actualiser le tableau 
                    (usclient as USER_Liste_Client).Actualisedatagrid();
                    MessageBox.Show("Client modifier avec succés","Modification",MessageBoxButtons.OK,MessageBoxIcon.Asterisk) ;
                }
                else
                {
                    MessageBox.Show("Modification annulé", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                


            }
        }

        private void btnactualiser_Click(object sender, EventArgs e)
        {
            txtnom.Text = "Nom de Client";
            txtnom.ForeColor = Color.Silver;
            txtadresse.Text = "Adresse de Client";
            txtadresse.ForeColor = Color.Silver;
            txtpays.Text = "Pays de Client";
            txtpays.ForeColor = Color.Silver;
            txtprenom.Text = "Prenom de Client";
            txtprenom.ForeColor = Color.Silver;
            txttelephone.Text = "Telephone de Client";
            txttelephone.ForeColor = Color.Silver;
            txtemail.Text = "Email de Client";
            txtemail.ForeColor = Color.Silver;
            txtville.Text = "Ville de Client";
            txtville.ForeColor = Color.Silver;

        }

        private void FRM_Ajouter_Modifier_Client_Load(object sender, EventArgs e)
        {

        }
    }
}
