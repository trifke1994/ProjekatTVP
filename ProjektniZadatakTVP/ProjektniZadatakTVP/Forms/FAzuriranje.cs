using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProjektniZadatakTVP.Classes;
using System.IO;
using ProjektniZadatakTVP.Data;
using System.Xml.Linq;
using System.Xml;

namespace ProjektniZadatakTVP.Forms
{
    public partial class FAzuriranje : Form
    {
        public int Parametar { get; set; }
        private DProjekatTVP _ds;
        public pnlPrikaz neki;
        private static string putanjaAplikacije = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        private string[] pslike = Directory.GetFiles(putanjaAplikacije + @"\slike");
        private string putanjaAutora = Path.Combine(putanjaAplikacije, "autori.bl");
        private List<Slika> sveslike =new List<Slika>();

        PictureBox[,] pc;

        public FAzuriranje()
        {
            InitializeComponent();
            Init();
        }
        public DataGridViewColumn KreirajKolonu(string naziv, string naslov, bool vidljivost, int sirina, DataGridViewCell dc)
        {
            DataGridViewColumn dvc = new DataGridViewColumn();
            dvc.CellTemplate = dc;
            dvc.DefaultCellStyle = new DataGridViewCellStyle();
            dvc.DataPropertyName = naziv;
            dvc.HeaderText = naslov;
            dvc.Name = naziv;
            dvc.Visible = vidljivost;
            dvc.Width = sirina;
            return dvc;
        }

        public void povezi()
        {

        }
        public void Init()
        {

            _ds = new DProjekatTVP();
            switch (Parametar)
            {
                case (int)TipForme.AzuriranjeAutora:
                    this.Text = "Azuriranje autora";
                    lblNaslovGrida.Text = "Autori";
                    DAL.GetTable("SELECT * FROM Autori", _ds.Tables["Autori"]);

                    dg.AutoGenerateColumns = false;
                    dg.DataSource = _ds.Tables["Autori"];
                    pnlSlike.Visible = false;
                    dg.Columns.Add(KreirajKolonu("id", "ID", false, 100, new DataGridViewTextBoxCell()));
                    dg.Columns.Add(KreirajKolonu("ime", "Ime", true, 100, new DataGridViewTextBoxCell()));
                    dg.Columns.Add(KreirajKolonu("prezime", "Prezime", true, 100, new DataGridViewTextBoxCell()));
                    dg.Columns.Add(KreirajKolonu("datum_rodjenja", "Datum", true, 100, new DataGridViewTextBoxCell()));

                    break;
                case (int)TipForme.AzuriranjeKategorije:
                    this.Text = "Aziriranje kategorija";
                    lblNaslovGrida.Text = "Kategorije";
                    progressBar1.Visible = false;

                    DAL.GetTable("SELECT * FROM Kategorije", _ds.Tables["Kategorije"]);
                    pnlSlike.Visible = false;
                    dg.AutoGenerateColumns = false;
                    dg.Columns.Clear();
                    dg.DataSource = _ds.Tables["Kategorije"];

                    dg.Columns.Add(KreirajKolonu("id", "ID", false, 100, new DataGridViewTextBoxCell()));
                    dg.Columns.Add(KreirajKolonu("naziv_kategorije", "Naziv kategorije", true, 100, new DataGridViewTextBoxCell()));
                    break;
                case (int)TipForme.AzuriranjeSlika:
                    this.Text = "Azuriranje slika";
                    sveslike.Clear();
                    lblNaslovGrida.Visible = false;
                    dg.Visible = false;
                    pnlSlike.Visible = true;
                    uzmislike();
                    


                    InitSlike();

                    break;
                case (int)TipForme.Statistika:
                    pnlSlike.Visible = false;
                    dg.Visible = false;
                    lblNaslovGrida.Visible = false;
                    progressBar1.Visible = true;
                    progressBar1.Value = 70;
                    this.Load += FAzuriranje_Load;
                    neki.naPromenu += Neki_naPromenu1;


                    break;
                default:
                    break;
            }




        }

        private void Neki_naPromenu1(object sender, EventArgs e)
        {
            uzmi();
        }

        private void Neki_naPromenu()
        {
            uzmi();
        }

        public void uzmi()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Ocena");
            var i = doc.GetElementsByTagName("root");
            var j = i.Item(0).InnerText;

            progressBar1.Value = Convert.ToInt32(j);
        }
        private void FAzuriranje_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Ocena");
            var i=doc.GetElementsByTagName("root");
            var j = i.Item(0).InnerText;
            
            progressBar1.Value = Convert.ToInt32(j);
        }

        private void uzmislike()
        {
            sveslike.Clear();
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

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                switch (Parametar)
                {
                    case (int)TipForme.AzuriranjeAutora:
                        for (int i = 0; i < dg.Rows.Count - 1; i++)
                        {
                            DataRow drr = ((DataRowView)dg.Rows[i].DataBoundItem).Row;

                            switch (drr.RowState)
                            {
                                case DataRowState.Added:
                                    DAL.InsertTable("INSERT INTO Autori (ime,prezime,datum_rodjenja) VALUES(@ime,@prezime, @datum_rodjenja)", new object[] { drr["ime"].ToString(), drr["prezime"].ToString(), Convert.ToDateTime(drr["datum_rodjenja"]) });
                                    break;
                                case DataRowState.Modified:
                                    DAL.UpdateTble("UPDATE Autori SET ime=@ime , prezime=@prezime , datum_rodjenja=@datum_rodjenja where id=" + drr["id"].ToString(), new object[] { drr["ime"].ToString(), drr["prezime"].ToString(), Convert.ToDateTime(drr["datum_rodjenja"]) });
                                    break;
                                case DataRowState.Deleted:
                                    DAL.DeleteRow("DELETE * FROM Autori where id=" + drr["id"].ToString());
                                    break;
                                default:
                                    break;

                            }
                        }
                        break;
                    case (int)TipForme.AzuriranjeKategorije:
                        for (int i = 0; i < dg.Rows.Count - 1; i++)
                        {
                            DataRow drr = ((DataRowView)dg.Rows[i].DataBoundItem).Row;

                            switch (drr.RowState)
                            {
                                case DataRowState.Added:
                                    DAL.InsertTabeleKat("INSERT INTO Kategorije (naziv_kategorije) VALUES(@naziv_kategorije)", new object[] { drr["naziv_kategorije"].ToString() });
                                    break;
                                case DataRowState.Modified:
                                    DAL.UpdateTabeleKat("UPDATE Kategorije SET naziv_kategorije=@naziv_kategorije where id=" + drr["id"].ToString(), new object[] { drr["naziv_kategorije"].ToString() });
                                    break;
                                case DataRowState.Deleted:
                                    DAL.DeleteRow("DELETE * FROM Kategorije where id=" + drr["id"].ToString());
                                    break;
                                default:
                                    break;

                            }
                        }
                        break;
                    case (int)TipForme.AzuriranjeSlika:
                        OpenFileDialog fd = new OpenFileDialog();
                        fd.Filter= "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" +
                        "All files (*.*)|*.*";
                        fd.Multiselect = false;
                        fd.Title = "Izaberite sliku";
                        DialogResult re = fd.ShowDialog();
                        if (re==DialogResult.OK)
                        {
                            File.Copy(fd.FileName, putanjaAplikacije + @"\slike\"+ Path.GetFileName(fd.FileName), false);
                            string imefajla = Path.GetFileName(fd.FileName);
                            DAL.InsertIntoSlike("INSERT INTO Slicice(id_autora,id_kategorije,naziv,putanjaDoSlike) VALUES(@id_autora,@id_kategorije,@naziv,@putanjaDoSlike)",
                                new object[] { null, null, imefajla, putanjaAplikacije + @"\slike\" + imefajla });
                            DataRow dr = SlikazaUpis(putanjaAplikacije + @"\slike\" + Path.GetFileName(fd.FileName),imefajla);
                            Slika sl = new Slika(Convert.ToInt32(dr["id"]), dr["naziv"].ToString(), dr["putanjaDoSlike"].ToString(), null, null);
                            pnlSlike.Controls.Clear();
                            uzmislike();
                            InitSlike();
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception excep)
            {             
                MessageBox.Show("Dogodila se greska prlikom upisa u bazu.\n Poruka o gresci:" + excep.Message);
            }

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public DataRow SlikazaUpis(string putanja,string naziv)
        {
            uzmislike();
            return _ds.Tables["Slike"].AsEnumerable().FirstOrDefault(w=> w["naziv"].ToString()==naziv);
        }

        List<PictureBox> AllPicutures = new List<PictureBox>();
        public void InitSlike()
        {
            AllPicutures.Clear();
            int brs = sveslike.Count;
            if (brs==0)
            {
                return;
            }
            int w = pnlSlike.ClientRectangle.Width / brs;
            int h = pnlSlike.ClientRectangle.Height / brs;

            int x = 20;
            int y = 10;
            int newx = 0;
            int newy = 0;

            foreach (Slika sli in sveslike)
            {
                if (x>= pnlSlike.ClientSize.Width-w-10)
                {
                    newx = x;
                    y = y + h + 30;
                    newy = y;
                }
                else
                {
                    newy = y;
                }

                PictureBox pcb = new PictureBox();
                AllPicutures.Add(pcb);
                pcb.Image = Image.FromFile(sli.PutanjaDoSlike);
                pcb.Tag = sli.id;
                pcb.Location = new Point(newx, newy);
                pcb.SizeMode = PictureBoxSizeMode.StretchImage;
                pcb.MouseDoubleClick += Pcb_MouseDoubleClick;
                pnlSlike.Controls.Add(pcb);
                newy = y + h + 10;
                newx = newx + w + 10;

            }           
        }

        private void Pcb_MouseDoubleClick(object sender, MouseEventArgs e)
        {           
            Slike sl= new Slike();
            sl.picuture = (PictureBox)sender;
            sl.peba = sveslike.AsEnumerable().FirstOrDefault(w => w.id == Convert.ToInt32(sl.picuture.Tag));
            sl.Init();
            sl.Show();

        }

        public void refer()
        {
            int brs = sveslike.Count;
            int w = pnlSlike.Width/brs;
            int h = pnlSlike.Height/brs;

            int x = 20;
            int y = 10;
            int newx = 0;
            int newy = 0;

            foreach (PictureBox pc in AllPicutures)
            {
                if (newx >= pnlSlike.Width - w - 10)
                {
                    newx = x;
                    y = y + h + 20;
                    newy = y;
                }
                else
                {
                    newy = y;
                }
                          
                pc.Location = new Point(newx, newy);
                pc.SizeMode = PictureBoxSizeMode.StretchImage;
                //pcb.MouseDoubleClick += Pcb_MouseDoubleClick;
                // this.Controls.Add(pcb);
                newy = y + h + 10;
                newx = newx + w + 10;
            }
        }
    
        private void FAzuriranje_SizeChanged(object sender, EventArgs e)
        {
            if (Parametar==(int)TipForme.AzuriranjeSlika)
            {
                refer();
            }
           

        }     
    }
}
