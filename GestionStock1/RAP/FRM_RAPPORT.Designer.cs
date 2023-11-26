namespace GestionStock1.RAP
{
    partial class FRM_RAPPORT
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
            this.RPAffchier = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RPAffchier
            // 
            this.RPAffchier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RPAffchier.Location = new System.Drawing.Point(0, 0);
            this.RPAffchier.Name = "RPAffchier";
            this.RPAffchier.ServerReport.BearerToken = null;
            this.RPAffchier.Size = new System.Drawing.Size(979, 703);
            this.RPAffchier.TabIndex = 0;
            // 
            // FRM_RAPPORT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 703);
            this.Controls.Add(this.RPAffchier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_RAPPORT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapport";
            this.Load += new System.EventHandler(this.FRM_RAPPORT_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer RPAffchier;
    }
}