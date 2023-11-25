namespace GestionStock1.PL
{
    partial class USER_Liste_Produit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtrecherche = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnsupprimerproduit = new System.Windows.Forms.Button();
            this.btnajouterproduit = new System.Windows.Forms.Button();
            this.comborecherche = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnmodifierproduit = new System.Windows.Forms.Button();
            this.dvgclient = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnafficherphotoproduit = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnimprimertout = new System.Windows.Forms.Button();
            this.btnimprimerselect = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgclient)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel4.Location = new System.Drawing.Point(623, 182);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(284, 2);
            this.panel4.TabIndex = 24;
            // 
            // txtrecherche
            // 
            this.txtrecherche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtrecherche.BackColor = System.Drawing.SystemColors.Control;
            this.txtrecherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrecherche.ForeColor = System.Drawing.Color.Gray;
            this.txtrecherche.Location = new System.Drawing.Point(623, 140);
            this.txtrecherche.Multiline = true;
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.Size = new System.Drawing.Size(284, 36);
            this.txtrecherche.TabIndex = 23;
            this.txtrecherche.Text = "Recherche";
            this.txtrecherche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtrecherche.Enter += new System.EventHandler(this.txtrecherche_Enter);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(19, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 2);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1104, 2);
            this.panel2.TabIndex = 4;
            // 
            // btnsupprimerproduit
            // 
            this.btnsupprimerproduit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnsupprimerproduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnsupprimerproduit.FlatAppearance.BorderSize = 0;
            this.btnsupprimerproduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsupprimerproduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupprimerproduit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsupprimerproduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsupprimerproduit.Location = new System.Drawing.Point(552, 21);
            this.btnsupprimerproduit.Name = "btnsupprimerproduit";
            this.btnsupprimerproduit.Size = new System.Drawing.Size(285, 68);
            this.btnsupprimerproduit.TabIndex = 20;
            this.btnsupprimerproduit.Text = "Supprimer";
            this.btnsupprimerproduit.UseVisualStyleBackColor = false;
            // 
            // btnajouterproduit
            // 
            this.btnajouterproduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnajouterproduit.FlatAppearance.BorderSize = 0;
            this.btnajouterproduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajouterproduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouterproduit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnajouterproduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnajouterproduit.Location = new System.Drawing.Point(19, 21);
            this.btnajouterproduit.Name = "btnajouterproduit";
            this.btnajouterproduit.Size = new System.Drawing.Size(253, 68);
            this.btnajouterproduit.TabIndex = 18;
            this.btnajouterproduit.Text = "Ajouter";
            this.btnajouterproduit.UseVisualStyleBackColor = false;
            this.btnajouterproduit.Click += new System.EventHandler(this.btnajouterproduit_Click);
            // 
            // comborecherche
            // 
            this.comborecherche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comborecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comborecherche.FormattingEnabled = true;
            this.comborecherche.Items.AddRange(new object[] {
            "Nom",
            "Categorie"});
            this.comborecherche.Location = new System.Drawing.Point(242, 147);
            this.comborecherche.Name = "comborecherche";
            this.comborecherche.Size = new System.Drawing.Size(339, 37);
            this.comborecherche.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel3.Location = new System.Drawing.Point(16, 216);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1104, 2);
            this.panel3.TabIndex = 22;
            // 
            // btnmodifierproduit
            // 
            this.btnmodifierproduit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnmodifierproduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnmodifierproduit.FlatAppearance.BorderSize = 0;
            this.btnmodifierproduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodifierproduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifierproduit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnmodifierproduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmodifierproduit.Location = new System.Drawing.Point(278, 21);
            this.btnmodifierproduit.Name = "btnmodifierproduit";
            this.btnmodifierproduit.Size = new System.Drawing.Size(268, 68);
            this.btnmodifierproduit.TabIndex = 19;
            this.btnmodifierproduit.Text = "Modifier";
            this.btnmodifierproduit.UseVisualStyleBackColor = false;
            this.btnmodifierproduit.Click += new System.EventHandler(this.btnmodifierproduit_Click);
            // 
            // dvgclient
            // 
            this.dvgclient.AllowUserToAddRows = false;
            this.dvgclient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgclient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgclient.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgclient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgclient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgclient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dvgclient.EnableHeadersVisualStyles = false;
            this.dvgclient.Location = new System.Drawing.Point(3, 247);
            this.dvgclient.Name = "dvgclient";
            this.dvgclient.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgclient.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dvgclient.RowHeadersWidth = 51;
            this.dvgclient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvgclient.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dvgclient.RowTemplate.Height = 24;
            this.dvgclient.Size = new System.Drawing.Size(1131, 358);
            this.dvgclient.TabIndex = 26;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Select";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "ID";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantite";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prix";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Categorie";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btnafficherphotoproduit
            // 
            this.btnafficherphotoproduit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnafficherphotoproduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnafficherphotoproduit.FlatAppearance.BorderSize = 0;
            this.btnafficherphotoproduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnafficherphotoproduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnafficherphotoproduit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnafficherphotoproduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnafficherphotoproduit.Location = new System.Drawing.Point(843, 21);
            this.btnafficherphotoproduit.Name = "btnafficherphotoproduit";
            this.btnafficherphotoproduit.Size = new System.Drawing.Size(280, 68);
            this.btnafficherphotoproduit.TabIndex = 27;
            this.btnafficherphotoproduit.Text = "Afficher Photo";
            this.btnafficherphotoproduit.UseVisualStyleBackColor = false;
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnsupprimer.FlatAppearance.BorderSize = 0;
            this.btnsupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupprimer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsupprimer.Location = new System.Drawing.Point(733, 630);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(390, 68);
            this.btnsupprimer.TabIndex = 30;
            this.btnsupprimer.Text = "sauvegarder dans Excel";
            this.btnsupprimer.UseVisualStyleBackColor = false;
            // 
            // btnimprimertout
            // 
            this.btnimprimertout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnimprimertout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnimprimertout.FlatAppearance.BorderSize = 0;
            this.btnimprimertout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimertout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimertout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnimprimertout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimprimertout.Location = new System.Drawing.Point(378, 630);
            this.btnimprimertout.Name = "btnimprimertout";
            this.btnimprimertout.Size = new System.Drawing.Size(349, 68);
            this.btnimprimertout.TabIndex = 29;
            this.btnimprimertout.Text = "Imprimer toutes";
            this.btnimprimertout.UseVisualStyleBackColor = false;
            // 
            // btnimprimerselect
            // 
            this.btnimprimerselect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnimprimerselect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnimprimerselect.FlatAppearance.BorderSize = 0;
            this.btnimprimerselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimerselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimerselect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnimprimerselect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimprimerselect.Location = new System.Drawing.Point(19, 630);
            this.btnimprimerselect.Name = "btnimprimerselect";
            this.btnimprimerselect.Size = new System.Drawing.Size(353, 68);
            this.btnimprimerselect.TabIndex = 28;
            this.btnimprimerselect.Text = "Imprimer PR coche";
            this.btnimprimerselect.UseVisualStyleBackColor = false;
            // 
            // USER_Liste_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnsupprimer);
            this.Controls.Add(this.btnimprimertout);
            this.Controls.Add(this.btnimprimerselect);
            this.Controls.Add(this.btnafficherphotoproduit);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtrecherche);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnsupprimerproduit);
            this.Controls.Add(this.btnajouterproduit);
            this.Controls.Add(this.comborecherche);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnmodifierproduit);
            this.Controls.Add(this.dvgclient);
            this.Name = "USER_Liste_Produit";
            this.Size = new System.Drawing.Size(1137, 720);
            this.Load += new System.EventHandler(this.USER_Liste_Produit_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgclient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtrecherche;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnsupprimerproduit;
        private System.Windows.Forms.Button btnajouterproduit;
        private System.Windows.Forms.ComboBox comborecherche;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnmodifierproduit;
        private System.Windows.Forms.DataGridView dvgclient;
        private System.Windows.Forms.Button btnafficherphotoproduit;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnimprimertout;
        private System.Windows.Forms.Button btnimprimerselect;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
