namespace GestionStock1.PL
{
    partial class FRM_Ajouter_Modifier_Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitreP = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtadresse = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtpays = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.txttelephone = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.txtville = new System.Windows.Forms.TextBox();
            this.btnquitter = new System.Windows.Forms.Button();
            this.btnactualiser = new System.Windows.Forms.Button();
            this.btnenregistrer = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitreP
            // 
            this.lblTitreP.AutoSize = true;
            this.lblTitreP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreP.ForeColor = System.Drawing.Color.Silver;
            this.lblTitreP.Location = new System.Drawing.Point(98, 21);
            this.lblTitreP.Name = "lblTitreP";
            this.lblTitreP.Size = new System.Drawing.Size(209, 36);
            this.lblTitreP.TabIndex = 0;
            this.lblTitreP.Text = "Ajouter Client";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.textBox2);
            this.panel5.Location = new System.Drawing.Point(76, 183);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(337, 1);
            this.panel5.TabIndex = 21;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel6.Location = new System.Drawing.Point(0, 75);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(337, 1);
            this.panel6.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox2.Location = new System.Drawing.Point(2, 42);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(286, 38);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Nom d\'utilisateur";
            // 
            // txtnom
            // 
            this.txtnom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.txtnom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtnom.Location = new System.Drawing.Point(78, 150);
            this.txtnom.Multiline = true;
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(286, 38);
            this.txtnom.TabIndex = 20;
            this.txtnom.Text = "Nom de Client";
            this.txtnom.Enter += new System.EventHandler(this.txtnom_Enter);
            this.txtnom.Leave += new System.EventHandler(this.txtnom_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(80, 402);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 1);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 1);
            this.panel2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Location = new System.Drawing.Point(2, 42);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 38);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Nom d\'utilisateur";
            // 
            // txtadresse
            // 
            this.txtadresse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.txtadresse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtadresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadresse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtadresse.Location = new System.Drawing.Point(80, 258);
            this.txtadresse.Multiline = true;
            this.txtadresse.Name = "txtadresse";
            this.txtadresse.Size = new System.Drawing.Size(286, 138);
            this.txtadresse.TabIndex = 22;
            this.txtadresse.Text = "Adresse de Client";
            this.txtadresse.Enter += new System.EventHandler(this.txtadresse_Enter);
            this.txtadresse.Leave += new System.EventHandler(this.txtadresse_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Location = new System.Drawing.Point(78, 508);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 1);
            this.panel3.TabIndex = 25;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Location = new System.Drawing.Point(0, 75);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(337, 1);
            this.panel4.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox4.Location = new System.Drawing.Point(2, 42);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(286, 38);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "Nom d\'utilisateur";
            // 
            // txtpays
            // 
            this.txtpays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.txtpays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpays.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtpays.Location = new System.Drawing.Point(80, 475);
            this.txtpays.Multiline = true;
            this.txtpays.Name = "txtpays";
            this.txtpays.Size = new System.Drawing.Size(286, 38);
            this.txtpays.TabIndex = 24;
            this.txtpays.Text = "Pays de Client";
            this.txtpays.Enter += new System.EventHandler(this.txtpays_Enter);
            this.txtpays.Leave += new System.EventHandler(this.txtpays_Leave);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.textBox6);
            this.panel7.Location = new System.Drawing.Point(513, 183);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(337, 1);
            this.panel7.TabIndex = 27;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel8.Location = new System.Drawing.Point(0, 75);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(337, 1);
            this.panel8.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox6.Location = new System.Drawing.Point(2, 42);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(286, 38);
            this.textBox6.TabIndex = 7;
            this.textBox6.Text = "Nom d\'utilisateur";
            // 
            // txtprenom
            // 
            this.txtprenom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.txtprenom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtprenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtprenom.Location = new System.Drawing.Point(515, 150);
            this.txtprenom.Multiline = true;
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(286, 38);
            this.txtprenom.TabIndex = 26;
            this.txtprenom.Text = "Prenom de Client";
            this.txtprenom.Enter += new System.EventHandler(this.txtprenom_Enter);
            this.txtprenom.Leave += new System.EventHandler(this.txtprenom_Leave);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.textBox8);
            this.panel9.Location = new System.Drawing.Point(513, 291);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(337, 1);
            this.panel9.TabIndex = 29;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel10.Location = new System.Drawing.Point(0, 75);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(337, 1);
            this.panel10.TabIndex = 8;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox8.Location = new System.Drawing.Point(2, 42);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(286, 38);
            this.textBox8.TabIndex = 7;
            this.textBox8.Text = "Nom d\'utilisateur";
            // 
            // txttelephone
            // 
            this.txttelephone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.txttelephone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelephone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txttelephone.Location = new System.Drawing.Point(515, 258);
            this.txttelephone.Multiline = true;
            this.txttelephone.Name = "txttelephone";
            this.txttelephone.Size = new System.Drawing.Size(286, 38);
            this.txttelephone.TabIndex = 28;
            this.txttelephone.Text = "Telephone de Client";
            this.txttelephone.Enter += new System.EventHandler(this.txttelephone_Enter);
            this.txttelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelephone_KeyPress);
            this.txttelephone.Leave += new System.EventHandler(this.txttelephone_Leave);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.textBox10);
            this.panel11.Location = new System.Drawing.Point(513, 402);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(337, 1);
            this.panel11.TabIndex = 31;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel12.Location = new System.Drawing.Point(0, 75);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(337, 1);
            this.panel12.TabIndex = 8;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox10.Location = new System.Drawing.Point(2, 42);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(286, 38);
            this.textBox10.TabIndex = 7;
            this.textBox10.Text = "Nom d\'utilisateur";
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtemail.Location = new System.Drawing.Point(513, 369);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(286, 38);
            this.txtemail.TabIndex = 30;
            this.txtemail.Text = "Email de Client";
            this.txtemail.Enter += new System.EventHandler(this.txtemail_Enter);
            this.txtemail.Leave += new System.EventHandler(this.txtemail_Leave);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel13.Controls.Add(this.panel14);
            this.panel13.Controls.Add(this.textBox12);
            this.panel13.Location = new System.Drawing.Point(511, 508);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(337, 1);
            this.panel13.TabIndex = 33;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel14.Location = new System.Drawing.Point(0, 75);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(337, 1);
            this.panel14.TabIndex = 8;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox12.Location = new System.Drawing.Point(2, 42);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(286, 38);
            this.textBox12.TabIndex = 7;
            this.textBox12.Text = "Nom d\'utilisateur";
            // 
            // txtville
            // 
            this.txtville.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.txtville.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtville.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtville.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtville.Location = new System.Drawing.Point(513, 475);
            this.txtville.Multiline = true;
            this.txtville.Name = "txtville";
            this.txtville.Size = new System.Drawing.Size(286, 38);
            this.txtville.TabIndex = 32;
            this.txtville.Text = "Ville de Client";
            this.txtville.Enter += new System.EventHandler(this.txtville_Enter);
            this.txtville.Leave += new System.EventHandler(this.txtville_Leave);
            // 
            // btnquitter
            // 
            this.btnquitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnquitter.FlatAppearance.BorderSize = 0;
            this.btnquitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquitter.Image = global::GestionStock1.Properties.Resources.Button_Delete_icon;
            this.btnquitter.Location = new System.Drawing.Point(855, 12);
            this.btnquitter.Name = "btnquitter";
            this.btnquitter.Size = new System.Drawing.Size(67, 67);
            this.btnquitter.TabIndex = 34;
            this.btnquitter.UseVisualStyleBackColor = true;
            this.btnquitter.Click += new System.EventHandler(this.btnquitter_Click);
            // 
            // btnactualiser
            // 
            this.btnactualiser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnactualiser.FlatAppearance.BorderSize = 0;
            this.btnactualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualiser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnactualiser.Location = new System.Drawing.Point(37, 550);
            this.btnactualiser.Name = "btnactualiser";
            this.btnactualiser.Size = new System.Drawing.Size(341, 57);
            this.btnactualiser.TabIndex = 35;
            this.btnactualiser.Text = "Actualiser";
            this.btnactualiser.UseVisualStyleBackColor = false;
            this.btnactualiser.Click += new System.EventHandler(this.btnactualiser_Click);
            // 
            // btnenregistrer
            // 
            this.btnenregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnenregistrer.FlatAppearance.BorderSize = 0;
            this.btnenregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenregistrer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnenregistrer.Location = new System.Drawing.Point(504, 550);
            this.btnenregistrer.Name = "btnenregistrer";
            this.btnenregistrer.Size = new System.Drawing.Size(341, 57);
            this.btnenregistrer.TabIndex = 36;
            this.btnenregistrer.Text = "Enregistrer";
            this.btnenregistrer.UseVisualStyleBackColor = false;
            this.btnenregistrer.Click += new System.EventHandler(this.btnenregistrer_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel15.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel15.Location = new System.Drawing.Point(932, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(2, 638);
            this.panel15.TabIndex = 37;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel16.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel16.Location = new System.Drawing.Point(0, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(932, 2);
            this.panel16.TabIndex = 38;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel17.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel17.Location = new System.Drawing.Point(0, 2);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(2, 636);
            this.panel17.TabIndex = 39;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel18.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel18.Location = new System.Drawing.Point(2, 636);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(930, 2);
            this.panel18.TabIndex = 40;
            // 
            // FRM_Ajouter_Modifier_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(934, 638);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.btnenregistrer);
            this.Controls.Add(this.btnactualiser);
            this.Controls.Add(this.btnquitter);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.txtville);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.txttelephone);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txtprenom);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtpays);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtadresse);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.lblTitreP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Ajouter_Modifier_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Ajouter_Modifier_Client";
            this.Load += new System.EventHandler(this.FRM_Ajouter_Modifier_Client_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Button btnquitter;
        private System.Windows.Forms.Button btnenregistrer;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        public System.Windows.Forms.Label lblTitreP;
        public System.Windows.Forms.Button btnactualiser;
        public System.Windows.Forms.TextBox txtnom;
        public System.Windows.Forms.TextBox txtadresse;
        public System.Windows.Forms.TextBox txtpays;
        public System.Windows.Forms.TextBox txtprenom;
        public System.Windows.Forms.TextBox txttelephone;
        public System.Windows.Forms.TextBox txtemail;
        public System.Windows.Forms.TextBox txtville;
    }
}