namespace ProjektniZadatakTVP.Forms
{
    partial class Slike
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
            this.pcbSlika = new System.Windows.Forms.PictureBox();
            this.cmbAutori = new System.Windows.Forms.ComboBox();
            this.cmbKategorije = new System.Windows.Forms.ComboBox();
            this.textboxnaziv = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbSlika
            // 
            this.pcbSlika.Location = new System.Drawing.Point(12, 12);
            this.pcbSlika.Name = "pcbSlika";
            this.pcbSlika.Size = new System.Drawing.Size(542, 277);
            this.pcbSlika.TabIndex = 0;
            this.pcbSlika.TabStop = false;
            // 
            // cmbAutori
            // 
            this.cmbAutori.FormattingEnabled = true;
            this.cmbAutori.Location = new System.Drawing.Point(12, 320);
            this.cmbAutori.Name = "cmbAutori";
            this.cmbAutori.Size = new System.Drawing.Size(112, 21);
            this.cmbAutori.TabIndex = 1;
            // 
            // cmbKategorije
            // 
            this.cmbKategorije.FormattingEnabled = true;
            this.cmbKategorije.Location = new System.Drawing.Point(142, 321);
            this.cmbKategorije.Name = "cmbKategorije";
            this.cmbKategorije.Size = new System.Drawing.Size(112, 21);
            this.cmbKategorije.TabIndex = 2;
            // 
            // textboxnaziv
            // 
            this.textboxnaziv.Location = new System.Drawing.Point(273, 322);
            this.textboxnaziv.Name = "textboxnaziv";
            this.textboxnaziv.Size = new System.Drawing.Size(105, 20);
            this.textboxnaziv.TabIndex = 3;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(398, 357);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 4;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(479, 357);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btnSacuvaj.TabIndex = 5;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(12, 304);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(34, 13);
            this.lblA.TabIndex = 6;
            this.lblA.Text = "Autori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kategorije";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Naziv";
            // 
            // Slike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 392);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.textboxnaziv);
            this.Controls.Add(this.cmbKategorije);
            this.Controls.Add(this.cmbAutori);
            this.Controls.Add(this.pcbSlika);
            this.Name = "Slike";
            this.Text = "Slike";
            ((System.ComponentModel.ISupportInitialize)(this.pcbSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbSlika;
        private System.Windows.Forms.ComboBox cmbAutori;
        private System.Windows.Forms.ComboBox cmbKategorije;
        private System.Windows.Forms.TextBox textboxnaziv;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}