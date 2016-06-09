namespace ProjektniZadatakTVP.Forms
{
    partial class FAzuriranje
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.dg = new System.Windows.Forms.DataGridView();
            this.lblNaslovGrida = new System.Windows.Forms.Label();
            this.pnlSlike = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblocena = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.pnlSlike.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodaj.Location = new System.Drawing.Point(268, 226);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdustani.Location = new System.Drawing.Point(187, 226);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 5;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // dg
            // 
            this.dg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(3, 33);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(351, 169);
            this.dg.TabIndex = 6;
            // 
            // lblNaslovGrida
            // 
            this.lblNaslovGrida.AutoSize = true;
            this.lblNaslovGrida.Location = new System.Drawing.Point(12, 9);
            this.lblNaslovGrida.Name = "lblNaslovGrida";
            this.lblNaslovGrida.Size = new System.Drawing.Size(35, 13);
            this.lblNaslovGrida.TabIndex = 7;
            this.lblNaslovGrida.Text = "label1";
            // 
            // pnlSlike
            // 
            this.pnlSlike.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSlike.Controls.Add(this.lblocena);
            this.pnlSlike.Location = new System.Drawing.Point(3, 25);
            this.pnlSlike.Name = "pnlSlike";
            this.pnlSlike.Size = new System.Drawing.Size(351, 195);
            this.pnlSlike.TabIndex = 8;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 226);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(247, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // lblocena
            // 
            this.lblocena.AutoSize = true;
            this.lblocena.Location = new System.Drawing.Point(9, 23);
            this.lblocena.Name = "lblocena";
            this.lblocena.Size = new System.Drawing.Size(73, 13);
            this.lblocena.TabIndex = 9;
            this.lblocena.Text = "Prosek ocena";
            // 
            // FAzuriranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 261);
            this.Controls.Add(this.pnlSlike);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblNaslovGrida);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodaj);
            this.Name = "FAzuriranje";
            this.Text = "FAzuriranje";
            this.SizeChanged += new System.EventHandler(this.FAzuriranje_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.pnlSlike.ResumeLayout(false);
            this.pnlSlike.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Label lblNaslovGrida;
        private System.Windows.Forms.Panel pnlSlike;
        private System.Windows.Forms.Label lblocena;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}