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
using ProjektniZadatakTVP.Forms;
using ProjektniZadatakTVP.Classes;
using System.Xml.Linq;

namespace ProjektniZadatakTVP
{
    public partial class pnlPrikaz : Form
    {

        private int parametar;
        private DataSet _ds;
        private List<Slika> sveslike = new List<Slika>();
        private Dictionary<int, int> slikaoc = new Dictionary<int, int>();
        public delegate void promena(object sender,EventArgs e);
        public event promena naPromenu;


        public pnlPrikaz()
        {
            InitializeComponent();
            _ds = new DProjekatTVP();
            DAL.GetTable("Select * from Slicice", _ds.Tables["Slike"]);
            DAL.GetTable("SELECT * FROM Kategorije", _ds.Tables["Kategorije"]);
            DAL.GetTable("SELECT * FROM Autori", _ds.Tables["Autori"]);


            cmbKategorije.DataSource = _ds.Tables["Kategorije"];
            cmbKategorije.ValueMember = "id";
            cmbKategorije.DisplayMember = "naziv_kategorije";
            uzmislike(Convert.ToInt32(cmbKategorije.SelectedValue));
            //promena = btnOceni_Click(this,null);
           


        }

        private void PnlPrikaz_naPromenu(object sender, EventArgs e)
        {
            btnOceni_Click(this,null);
        }

        private void menuItemAutor_Click(object sender, EventArgs e)
        {
            FAzuriranje fa = new FAzuriranje();
            fa.Parametar = (int)TipForme.AzuriranjeAutora;
            fa.Show();
        }

        private void menuItemKategorija_Click(object sender, EventArgs e)
        {
            FAzuriranje fa = new FAzuriranje();
            fa.Parametar = (int)TipForme.AzuriranjeKategorije;
            fa.Init();
            fa.Show();
        }

        private void menuItemSlika_Click(object sender, EventArgs e)
        {
            FAzuriranje fa = new FAzuriranje();
            fa.Parametar = (int)TipForme.AzuriranjeSlika;
            fa.Init();
            fa.Show();
        }




        private void uzmislike()
        {
            _ds.Tables["Slike"].Clear();
            DAL.GetTable("Select * from Slicice", _ds.Tables["Slike"]);
            foreach (DataRow dr in _ds.Tables["Slike"].Rows)
            {
                if (dr["id_kategorije"] == DBNull.Value || dr["id_autora"] == DBNull.Value)
                {
                    //dr["id_kategorije"] = null;
                    //dr["id_autora"] = null;
                    Slika sl = new Slika(Convert.ToInt32(dr["id"]), dr["naziv"].ToString(), dr["putanjaDoSlike"].ToString(), null, null);
                    sveslike.Add(sl);
                }
                else
                {
                    Slika sl = new Slika(Convert.ToInt32(dr["id"]), dr["naziv"].ToString(), dr["putanjaDoSlike"].ToString(), Convert.ToInt32(dr["id_kategorije"]), Convert.ToInt32(dr["id_autora"]));
                    sveslike.Add(sl);
                }

            }
        }

        private void uzmislike(int katbr)
        {
            sveslike.Clear();
            _ds.Tables["Slike"].Clear();
            DAL.GetTable("Select * from Slicice", _ds.Tables["Slike"]);
            foreach (DataRow dr in _ds.Tables["Slike"].Rows)
            {
                if (dr["id_kategorije"] == DBNull.Value)
                {
                    continue;
                }
                if (Convert.ToInt32(dr["id_kategorije"]) == Convert.ToInt32(cmbKategorije.SelectedValue))
                {
                    Slika sl = new Slika(Convert.ToInt32(dr["id"]), dr["naziv"].ToString(), dr["putanjaDoSlike"].ToString(), Convert.ToInt32(dr["id_kategorije"]), Convert.ToInt32(dr["id_autora"]));
                    sveslike.Add(sl);
                }
            }
        }
        private void uzmislike(int katbr,string ima)
        {
            sveslike.Clear();
            _ds.Tables["Slike"].Clear();
            DAL.GetTable("Select * from Slicice", _ds.Tables["Slike"]);
            foreach (DataRow dr in _ds.Tables["Slike"].Rows)
            {
                if (dr["id_kategorije"] == DBNull.Value)
                {
                    continue;
                }
                int drs =(int)_ds.Tables["Autori"].AsEnumerable().First(f => txtbImeautora.Text == f["ime"].ToString())["id"];
                if (drs != null)
                {
                    if (Convert.ToInt32(dr["id_kategorije"]) == Convert.ToInt32(cmbKategorije.SelectedValue) && drs == Convert.ToInt32(dr["id_autora"]))
                    {
                        Slika sl = new Slika(Convert.ToInt32(dr["id"]), dr["naziv"].ToString(), dr["putanjaDoSlike"].ToString(), Convert.ToInt32(dr["id_kategorije"]), Convert.ToInt32(dr["id_autora"]));
                        sveslike.Add(sl);
                    }
                }
            }
        }
        int br = 0;
        private void btnSledeca_Click(object sender, EventArgs e)
        {
            if (br >= sveslike.Count)
            {
                br = 0;
            }
            pcbslika.Image = Image.FromFile(sveslike[br].PutanjaDoSlike);
            pcbslika.SizeMode = PictureBoxSizeMode.StretchImage;
            lblNazivslike.Text = sveslike[br].NazivSlike;
            lblNazivAutora.Text = _ds.Tables["Autori"].AsEnumerable().First(f => Convert.ToInt32(f["id"]) == sveslike[br].idAutora)["ime"].ToString();
            br++;
            if (br >= sveslike.Count)
            {
                br = 0;
            }

        }

        private void cmbKategorije_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbKategorije_Validated(object sender, EventArgs e)
        {
            if (txtbImeautora.Text != string.Empty)
            {
                return;
            }
            uzmislike(Convert.ToInt32(cmbKategorije.SelectedValue));
        }

        private void pnlPrikaz_Load(object sender, EventArgs e)
        {
           // ucitajocene();
            ////var i = slikaoc.Keys.AsEnumerable().Where(w => w == sveslike[br].id);
            foreach (int item in slikaoc.Keys)
            {
                foreach (int value in slikaoc.Values)
                {
                    if (item==sveslike[br].id)
                    {
                        if (value==1)
                        {
                            radioButton1.Checked=true;
                        }
                        if (value==2)
                        {
                            radioButton2.Checked = true;
                        }
                        if (value==3)
                        {
                            radioButton3.Checked = true;
                        }
                        if (value==4)
                        {
                            radioButton4.Checked = true;
                        }
                        if (value==5)
                        {
                            radioButton5.Checked = true;
                        }
                    }
                }
            }            
        }
        int ocena = 0;
        int broj = 0;
        private void btnOceni_Click(object sender, EventArgs e)
        {
            //if (broj<=0)
           
                naPromenu(this,null);
              //  broj++;
            //}
            
            if (radioButton1.Checked)
            {
                ocena = 1;
            }
            if (radioButton2.Checked)
            {
                ocena = 2;
            }
            if (radioButton3.Checked)
            {
                ocena = 3;
            }
            if (radioButton4.Checked)
            {
                ocena = 4;
            }
            if (radioButton5.Checked)
            {
                ocena = 5;
            }


            if (slikaoc.ContainsKey(br))
            {
                int si = Convert.ToInt32(slikaoc.Where(w => w.Key == br).Select(s => s.Value));
                si = ocena;
            }
            else
            {
                slikaoc.Add(sveslike[br].id, ocena);
            }
            int suma = 0;
            foreach (int val in slikaoc.Values)
            {
                suma = +val;
            }
            XElement el = new XElement("root", suma / sveslike.Count);
            el.Save("Ocena");
        }


        public void ucitajocene()
        {
            XDocument docu = XDocument.Load("Ocena");
            //XElement nesto = docu.Elements();
            //XElement rootElement = XElement.Parse(docu.Document);
            
            // Dictionary<int, string> slikaoc = new Dictionary<string, string>();
            //foreach (var el in rootElement.Elements())
            //{
            //    slikaoc.Add(Convert.ToInt32(el.Name.LocalName),Convert.ToInt32(el.Value));
            //}

        }

        private void txtbImeautora_Validated(object sender, EventArgs e)
        {
            uzmislike(Convert.ToInt32(cmbKategorije.SelectedValue), txtbImeautora.Text);
        }

        private void menuItemStatistika_Click(object sender, EventArgs e)
        {
            FAzuriranje fa = new FAzuriranje();
            fa.neki = this;
            fa.Parametar = (int)TipForme.Statistika;
            fa.Init();
            fa.Show();
        }
    }

    enum TipForme
    {
        AzuriranjeAutora,
        AzuriranjeKategorije,
        AzuriranjeSlika,
        Ocene,
        Statistika
    }
}
