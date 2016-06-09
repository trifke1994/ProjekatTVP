using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProjektniZadatakTVP.Data;
using ProjektniZadatakTVP.Classes;

namespace ProjektniZadatakTVP.Forms
{
    public partial class Slike : Form
    {
        public PictureBox picuture { get; set; }
        internal Slika peba { get; set; }
        private DataSet _ds;
        public Slike()
        {
            InitializeComponent();
           
        }

        public void Init()
        {
            _ds = new DProjekatTVP();
            pcbSlika.Image = picuture.Image;
            pcbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            DAL.GetTable("SELECT * FROM Autori", _ds.Tables["Autori"]);
            DAL.GetTable("SELECT * FROM Kategorije", _ds.Tables["Kategorije"]);
            cmbAutori.DataSource = _ds.Tables["Autori"];
            cmbAutori.ValueMember = "id";
            cmbAutori.DisplayMember = "ime";
            cmbKategorije.DataSource = _ds.Tables["Kategorije"];
            cmbKategorije.ValueMember = "id";
            cmbKategorije.DisplayMember = "naziv_kategorije";


        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            DAL.UpdateTableSlike("UPDATE Slicice SET id_autora=@id_autora , id_kategorije=@id_kategorije ,naziv=@naziv where id=" + peba.id, new object[] {  Convert.ToInt32(cmbAutori.SelectedValue), Convert.ToInt32(cmbKategorije.SelectedValue), textboxnaziv.Text});
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
