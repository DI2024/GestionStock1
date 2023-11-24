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
    public partial class FRM_MENU : Form
    {
        public FRM_MENU()
        {
            InitializeComponent();
            panel1.Size = new Size(268, 662);
            pnlparamettre.Visible = false;
        }
        void desactiverForm()
        {
            btnclient.Enabled = false;
            btnproduit.Enabled = false;
            btncategorie.Enabled = false;
            btncommande.Enabled = false;
            btnutilisateur.Enabled = false;
            btncopie.Enabled = false;
            btnrestaure.Enabled = false;
            btnd.Enabled = false;
            pnlBut.Enabled = false;
            //connecte activer 
            btnc.Enabled = true;
            pnlparamettre.Visible = false;
        }
        //activer formulaire

        public void activerform()
        {
            btnclient.Enabled = true;
            btnproduit.Enabled = true;
            btncategorie.Enabled = true;
            btncommande.Enabled = true;
            btnutilisateur.Enabled = true;
            btncopie.Enabled = true;
            btnrestaure.Enabled = true;
            btnd.Enabled = true;
            pnlBut.Enabled = true;
            //connecte desactiver 
            btnc.Enabled = false;
            pnlparamettre.Visible = false;
        }


        private void button1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnc_Click(object sender, EventArgs e)
        {
            FRM_Connexion frmC = new FRM_Connexion(this); // this = FRM_MENU
            frmC.ShowDialog();
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            desactiverForm();
        }

        private void btnparamettre_Click(object sender, EventArgs e)
        {
            pnlparamettre.Size = new Size(373, 163);
            pnlparamettre.Visible = !pnlparamettre.Visible;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 268)
            {
                panel1.Size = new Size(77, 662);
            }
            else
            {
                panel1.Size = new Size(268, 662);
            }
        }

        private void btnclient_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnclient.Top;
            if (!pnlafficher.Controls.Contains(USER_Liste_Client.Instance))
            {
                pnlafficher.Controls.Add(USER_Liste_Client.Instance);
                USER_Liste_Client.Instance.Dock = DockStyle.Fill;
                USER_Liste_Client.Instance.BringToFront();
            }
        }

        private void btnproduit_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnproduit.Top;
        }

        private void btncategorie_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btncategorie.Top;
        }

        private void btncommande_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btncommande.Top;
        }

        private void btnutilisateur_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnutilisateur.Top;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FRM_MENU_Load(object sender, EventArgs e)
        {
            desactiverForm();
        }
    }
}
