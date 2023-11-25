using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock1.PL
{
    public partial class USER_Liste_Client : UserControl
    {
        private static USER_Liste_Client UserClient;
        private DbStockContext db;
        //creer un instance pour le usercontrole
        public static USER_Liste_Client Instance
        {
            get
            {
                if (UserClient == null)
                {
                    UserClient = new USER_Liste_Client();
                }
                return UserClient;
            }
        }

        public USER_Liste_Client()
        {
            InitializeComponent();
            db = new DbStockContext();
            //desactiver textbox de recherche
            txtrecherche.Enabled = false;
        }

        //ajouter dans le tableau
        public void Actualisedatagrid()
        {
            db = new DbStockContext();
            dvgclient.Rows.Clear(); //vider  le tableau
            foreach(var S in db.clients)
            {
                //ajouter les lignes dans le tableau
                dvgclient.Rows.Add(false,S.Id_client,S.Nom_client,S.Prenom_client,S.Adresse_client,S.Telephonne_client,S.Email_client,S.Ville_client,S.Pays_client);
            }
        }
        //verifier combien de ligne est selectionne
        public string SelectVerif()
        {
            int Nombreligneselect = 0;
            for (int i = 0;i<dvgclient.Rows.Count;i++)
            {
                if ((bool)dvgclient.Rows[i].Cells[0].Value) //si ligne est selectionee
                {
                    Nombreligneselect++;
                }
            }
            if (Nombreligneselect==0)
            {
                return "Selectionner la ligne que vous voulez modifier";
            }
            if (Nombreligneselect > 1)
            {
                return "Selectionner seulement 1 seul Client pour modifier";
            }
            return null;

        }
        private void dvgclient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtrecherche_Enter(object sender, EventArgs e)
        {
            if (txtrecherche.Text == "Recherche")
            {
                txtrecherche.Text = "";
                txtrecherche.ForeColor = Color.Black;

            }
        }

        private void USER_Liste_Client_Load(object sender, EventArgs e)
        {
            Actualisedatagrid();
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajouter_Modifier_Client frmclient=new FRM_Ajouter_Modifier_Client(this);
            frmclient.ShowDialog();
        }


        private void btnmodifier_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajouter_Modifier_Client frmclient = new PL.FRM_Ajouter_Modifier_Client(this);
            if(SelectVerif()==null)
            {
                for(int i = 0; i < dvgclient.Rows.Count; i++)
                {
                    if ((bool)dvgclient.Rows[i].Cells[0].Value == true) //si checkbox est vrai afficher les info
                    {
                        frmclient.IDselect = (int)dvgclient.Rows[i].Cells[1].Value;
                        frmclient.txtnom.Text = dvgclient.Rows[i].Cells[2].Value.ToString();
                        frmclient.txtprenom.Text=dvgclient.Rows[i].Cells[3].Value.ToString();
                        frmclient.txtadresse.Text = dvgclient.Rows[i].Cells[4].Value.ToString();
                        frmclient.txttelephone.Text = dvgclient.Rows[i].Cells[5].Value.ToString();
                        frmclient.txtemail.Text = dvgclient.Rows[i].Cells[6].Value.ToString();
                        frmclient.txtville.Text = dvgclient.Rows[i].Cells[8].Value.ToString();
                        frmclient.txtpays.Text = dvgclient.Rows[i].Cells[7].Value.ToString();

                    }
                }
                frmclient.lblTitreP.Text = "Modifer Client";
                frmclient.btnactualiser.Visible = false;
                frmclient.ShowDialog();
            }
            else
            {
                MessageBox.Show(SelectVerif(),"Modification", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            BL.CLS_Client clclient = new BL.CLS_Client();
            //pour supp toute les Clients selectionnee

            int select =0;
            for(int i = 0; i < dvgclient.Rows.Count; i++)
            {
                if ((bool)dvgclient.Rows[i].Cells[0].Value==true)
                {
                    select++; //combien de ligne selectionnée
                }
            }
            if (select == 0)
            {
                MessageBox.Show("aucun Client selectionné","Suppression",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {
                DialogResult R = MessageBox.Show("Voulez-vous vraiment supprimer ce Client?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R==DialogResult.Yes)
                {
                    //pour supprimez toute le clients selectionnée
                    for (int i = 0; i < dvgclient.Rows.Count; i++)
                    {
                        if ((bool)dvgclient.Rows[i].Cells[0].Value == true)
                        {
                            clclient.supprimer_Client(int.Parse(dvgclient.Rows[i].Cells[1].Value.ToString())); //id client  
                        }
                    }
                    //actualisez le tableau
                    Actualisedatagrid();
                    MessageBox.Show("Client supprimé", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Suppression annulé", "Suppression", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }

        private void comborecherche_SelectedIndexChanged(object sender, EventArgs e)
        {
            //activer txtrecherche si j'ai selectionné un champ
            txtrecherche.Enabled = true; 
            txtrecherche.Focus();
            txtrecherche.Text = ""; //vider txtrecherche
        }

        private void txtrecherche_TextChanged(object sender, EventArgs e)
        {
            db = new DbStockContext();
            var listerecherche =db.clients.ToList(); //liste de recherche = liste de clients
            if (txtrecherche.Text!="")
            {
                switch(comborecherche.Text)
                {
                    case "Nom":
                        listerecherche = listerecherche.Where(s => s.Nom_client.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase)!=-1).ToList(); break;
                        //stringcomparison.currentcultureignorecase = si maj ou mins
                        //!=-1 exist dans la bd 
                        break;
                    case "Prenom":
                        listerecherche = listerecherche.Where(s => s.Prenom_client.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList(); 
                        break;
                    case "Telephonne":
                        listerecherche = listerecherche.Where(s => s.Telephonne_client.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList(); 
                        break;
                    case "Email":
                        listerecherche = listerecherche.Where(s => s.Email_client.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList(); 
                        break;
                    case "Pays":
                        listerecherche = listerecherche.Where(s => s.Pays_client.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Ville":
                        listerecherche = listerecherche.Where(s => s.Ville_client.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                }
            }
            //vider le tableau
            dvgclient.Rows.Clear();
            //ajouter listerecherche dans le tableau client
            foreach (var L in listerecherche) 
            { 
                dvgclient.Rows.Add(false, L.Id_client,L.Nom_client,L.Prenom_client,L.Adresse_client,L.Telephonne_client,L.Email_client,L.Pays_client,L.Ville_client) ;
            }
        }
    }
}
