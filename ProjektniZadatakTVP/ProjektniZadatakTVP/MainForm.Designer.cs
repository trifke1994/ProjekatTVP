namespace ProjektniZadatakTVP
{
    partial class pnlPrikaz
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administracijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAutor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemKategorija = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSlika = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemStatistika = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbKategorije = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.pcbslika = new System.Windows.Forms.PictureBox();
            this.btnSledeca = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNazivAutora = new System.Windows.Forms.Label();
            this.lblslika = new System.Windows.Forms.Label();
            this.lblNazivslike = new System.Windows.Forms.Label();
            this.gb = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.btnOceni = new System.Windows.Forms.Button();
            this.txtbImeautora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbslika)).BeginInit();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administracijaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(712, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administracijaToolStripMenuItem
            // 
            this.administracijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAutor,
            this.menuItemKategorija,
            this.menuItemSlika,
            this.menuItemStatistika});
            this.administracijaToolStripMenuItem.Name = "administracijaToolStripMenuItem";
            this.administracijaToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.administracijaToolStripMenuItem.Text = "Administracija";
            // 
            // menuItemAutor
            // 
            this.menuItemAutor.Name = "menuItemAutor";
            this.menuItemAutor.Size = new System.Drawing.Size(182, 22);
            this.menuItemAutor.Text = "Ažuriranje autora";
            this.menuItemAutor.Click += new System.EventHandler(this.menuItemAutor_Click);
            // 
            // menuItemKategorija
            // 
            this.menuItemKategorija.Name = "menuItemKategorija";
            this.menuItemKategorija.Size = new System.Drawing.Size(182, 22);
            this.menuItemKategorija.Text = "Ažuriranje kategorija";
            this.menuItemKategorija.Click += new System.EventHandler(this.menuItemKategorija_Click);
            // 
            // menuItemSlika
            // 
            this.menuItemSlika.Name = "menuItemSlika";
            this.menuItemSlika.Size = new System.Drawing.Size(182, 22);
            this.menuItemSlika.Text = "Ažuriranje slika";
            this.menuItemSlika.Click += new System.EventHandler(this.menuItemSlika_Click);
            // 
            // menuItemStatistika
            // 
            this.menuItemStatistika.Name = "menuItemStatistika";
            this.menuItemStatistika.Size = new System.Drawing.Size(182, 22);
            this.menuItemStatistika.Text = "Statistika";
            this.menuItemStatistika.Click += new System.EventHandler(this.menuItemStatistika_Click);
            // 
            // cmbKategorije
            // 
            this.cmbKategorije.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbKategorije.FormattingEnabled = true;
            this.cmbKategorije.Location = new System.Drawing.Point(586, 27);
            this.cmbKategorije.Name = "cmbKategorije";
            this.cmbKategorije.Size = new System.Drawing.Size(114, 21);
            this.cmbKategorije.TabIndex = 1;
            this.cmbKategorije.SelectedIndexChanged += new System.EventHandler(this.cmbKategorije_SelectedIndexChanged);
            this.cmbKategorije.Validated += new System.EventHandler(this.cmbKategorije_Validated);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(494, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv kategorije:";
            // 
            // pcbslika
            // 
            this.pcbslika.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbslika.Location = new System.Drawing.Point(12, 57);
            this.pcbslika.Name = "pcbslika";
            this.pcbslika.Size = new System.Drawing.Size(688, 284);
            this.pcbslika.TabIndex = 3;
            this.pcbslika.TabStop = false;
            // 
            // btnSledeca
            // 
            this.btnSledeca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSledeca.Location = new System.Drawing.Point(625, 369);
            this.btnSledeca.Name = "btnSledeca";
            this.btnSledeca.Size = new System.Drawing.Size(75, 23);
            this.btnSledeca.TabIndex = 4;
            this.btnSledeca.Text = "Sledeca";
            this.btnSledeca.UseVisualStyleBackColor = true;
            this.btnSledeca.Click += new System.EventHandler(this.btnSledeca_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Naziv Autora:";
            // 
            // lblNazivAutora
            // 
            this.lblNazivAutora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNazivAutora.AutoSize = true;
            this.lblNazivAutora.Location = new System.Drawing.Point(106, 369);
            this.lblNazivAutora.Name = "lblNazivAutora";
            this.lblNazivAutora.Size = new System.Drawing.Size(0, 13);
            this.lblNazivAutora.TabIndex = 6;
            // 
            // lblslika
            // 
            this.lblslika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblslika.AutoSize = true;
            this.lblslika.Location = new System.Drawing.Point(198, 369);
            this.lblslika.Name = "lblslika";
            this.lblslika.Size = new System.Drawing.Size(61, 13);
            this.lblslika.TabIndex = 7;
            this.lblslika.Text = "Naziv slike:";
            // 
            // lblNazivslike
            // 
            this.lblNazivslike.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNazivslike.AutoSize = true;
            this.lblNazivslike.Location = new System.Drawing.Point(265, 369);
            this.lblNazivslike.Name = "lblNazivslike";
            this.lblNazivslike.Size = new System.Drawing.Size(0, 13);
            this.lblNazivslike.TabIndex = 8;
            // 
            // gb
            // 
            this.gb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gb.Controls.Add(this.radioButton1);
            this.gb.Controls.Add(this.radioButton5);
            this.gb.Controls.Add(this.radioButton4);
            this.gb.Controls.Add(this.radioButton2);
            this.gb.Controls.Add(this.radioButton3);
            this.gb.Location = new System.Drawing.Point(324, 359);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(229, 33);
            this.gb.TabIndex = 9;
            this.gb.TabStop = false;
            this.gb.Text = "Ocena";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(14, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(37, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = " 1 ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(183, 13);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(34, 17);
            this.radioButton5.TabIndex = 13;
            this.radioButton5.Text = "5 ";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(143, 13);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(34, 17);
            this.radioButton4.TabIndex = 12;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = " 4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(57, 13);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(37, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = " 2 ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(100, 13);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(37, 17);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = " 3 ";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // btnOceni
            // 
            this.btnOceni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOceni.Location = new System.Drawing.Point(559, 369);
            this.btnOceni.Name = "btnOceni";
            this.btnOceni.Size = new System.Drawing.Size(60, 23);
            this.btnOceni.TabIndex = 14;
            this.btnOceni.Text = "Oceni";
            this.btnOceni.UseVisualStyleBackColor = true;
            this.btnOceni.Click += new System.EventHandler(this.btnOceni_Click);
            // 
            // txtbImeautora
            // 
            this.txtbImeautora.Location = new System.Drawing.Point(388, 28);
            this.txtbImeautora.Name = "txtbImeautora";
            this.txtbImeautora.Size = new System.Drawing.Size(100, 20);
            this.txtbImeautora.TabIndex = 15;
            this.txtbImeautora.Validated += new System.EventHandler(this.txtbImeautora_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ime autora:";
            // 
            // pnlPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 404);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbImeautora);
            this.Controls.Add(this.btnOceni);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.lblNazivslike);
            this.Controls.Add(this.lblslika);
            this.Controls.Add(this.lblNazivAutora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSledeca);
            this.Controls.Add(this.pcbslika);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKategorije);
            this.Controls.Add(this.menuStrip1);
            this.Name = "pnlPrikaz";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.pnlPrikaz_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbslika)).EndInit();
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administracijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemAutor;
        private System.Windows.Forms.ToolStripMenuItem menuItemKategorija;
        private System.Windows.Forms.ToolStripMenuItem menuItemSlika;
        private System.Windows.Forms.ToolStripMenuItem menuItemStatistika;
        private System.Windows.Forms.ComboBox cmbKategorije;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcbslika;
        private System.Windows.Forms.Button btnSledeca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNazivAutora;
        private System.Windows.Forms.Label lblslika;
        private System.Windows.Forms.Label lblNazivslike;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Button btnOceni;
        private System.Windows.Forms.TextBox txtbImeautora;
        private System.Windows.Forms.Label label3;
    }
}

