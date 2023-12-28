using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drugi_projekat_TVP
{
    public partial class StartForm : Form
    {
      static public  RestoranDataSet ds;
        static public RestoranDataSetTableAdapters.JeloTableAdapter daJelo;
        static public RestoranDataSetTableAdapters.PrilogTableAdapter daPrilog;
        static public RestoranDataSetTableAdapters.PripadnostTableAdapter daPripadnost;
        static public RestoranDataSetTableAdapters.Stavka_racunaTableAdapter daStavka;
        static public RestoranDataSetTableAdapters.RacunTableAdapter daRacun;
        static public DataTable dtTrenutniRacun;
       static public int id_racun;
        Task tPomeraj,tUvecaj_smanji;
        DateTime dt;
        public StartForm()
        {
            InitializeComponent();

            ds = new RestoranDataSet();
            daJelo=new RestoranDataSetTableAdapters.JeloTableAdapter();
            daPrilog= new RestoranDataSetTableAdapters.PrilogTableAdapter();
            daPripadnost= new RestoranDataSetTableAdapters.PripadnostTableAdapter();
            daStavka=new RestoranDataSetTableAdapters.Stavka_racunaTableAdapter();
            daRacun=new RestoranDataSetTableAdapters.RacunTableAdapter();
            dgvJelo.CellDoubleClick +=DataGridView1_CellDoubleClick;
            dgvRacun.CellDoubleClick+=DgvRacun_CellDoubleClick;
            lblGrafika.Hide();
        }

        private void Pnl_Paint(object sender, PaintEventArgs e)
        {
          
            {
                Graphics dc = e.Graphics;

                
                
                SolidBrush sb = new SolidBrush(Color.Blue);
                SolidBrush sb1 = new SolidBrush(Color.Green);
                SolidBrush sb2 = new SolidBrush(Color.IndianRed);
                int id_jelo = (int)dgvJelo.SelectedRows[0].Cells["id_jelo"].Value;
                int ukupna_prodaja = (from s in ds.Stavka_racuna
                                      select s.kolicina).Sum();

                int prodaja_jela = (from s in ds.Stavka_racuna
                                    where s.id_jelo==id_jelo
                                    select s.kolicina).Sum();
                float mnozilac = (float)pnl.Height/ukupna_prodaja;
                dc.FillRectangle(sb, 0, 0, Width, (ukupna_prodaja-prodaja_jela)*mnozilac);
                dc.FillRectangle(sb2, 0, (ukupna_prodaja-prodaja_jela)*mnozilac,Width, (prodaja_jela)*mnozilac);
            }
           
        }

        bool manji_font = false;
        async void  PromeniFont()
        {
            while (true)
            {
                float velicina;
                Font font = lblNajprodavanijeJelo.Font;
                if(manji_font)
                {
                    velicina = font.Size  -1;
                    if(velicina < 10)
                        manji_font = false;
                }
                 
                else
                {
                    velicina=font.Size +1;
                    if (velicina>22)
                        manji_font=true;
                }
                    
                lblNajprodavanijeJelo.Font = new Font(font.FontFamily, velicina, font.Style);
                await Task.Delay(1000);
            }
        }
        bool to_left = true;
       async void Pomeraj()
        {
            while(true)
            {
                if (to_left)
                {
                    lblNajprodavanijeJelo.Left-=15;
                    await Task.Delay(300);
                    if (lblNajprodavanijeJelo.Left-15<0)
                        to_left=false;
                }
               else
                {

                    lblNajprodavanijeJelo.Left+=15;
                    await Task.Delay(300);
                    if (lblNajprodavanijeJelo.Left+15+lblNajprodavanijeJelo.Width>this.Width)
                        to_left=true;
                }
            }
            
        }
        string Najprodavanije_jelo()
        {
            var jela = from stavka in ds.Stavka_racuna
                       join racun in ds.Racun on stavka.id_racun equals racun.id_racun
                       where racun.datum.Date.Month == DateTime.Now.Month
                       group stavka by stavka.id_jelo into grupa
                       orderby grupa.Sum(stavka => stavka.kolicina) descending
                       select grupa.Key;
            
            int id_jela = jela.FirstOrDefault();
            if(id_jela!=0)
            {
                string ime_jela=(from j in ds.Jelo
                                 where j.id_jelo==id_jela
                                 select j.naziv).First();
                return "Najprodavanije jelo meseca: "+ime_jela;
            }
            else
            {
                return "Nema najprodavanijeg jela u tekucem mesecu";
            }
            
        }
      
        private void DgvRacun_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView dataGridView = (DataGridView)sender;
                DataGridViewCell idCell = dataGridView.Rows[e.RowIndex].Cells[0];

                int id = (int)idCell.Value;
                if (id>0)
                {
                    PrikazStavkiForm f=new PrikazStavkiForm(id);
                    f.Show();
                }

            }
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView dataGridView = (DataGridView)sender;

              
                DataGridViewCell idCell = dataGridView.Rows[e.RowIndex].Cells[0];


                int id = (int)idCell.Value;
                if(id>0)
                {
                    DodajStavkuRacunaForm f = new DodajStavkuRacunaForm(id);
                    f.Show();
                }
                
            }
           
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            daJelo.Fill(ds.Jelo);
            daPrilog.Fill(ds.Prilog);
            daPripadnost.Fill(ds.Pripadnost);

            dgvJelo.DataSource=ds.Jelo;
            daRacun.Fill(ds.Racun);
            daStavka.Fill(ds.Stavka_racuna);

            
            dt=DateTime.Now;
            daRacun.Insert(0, dt);    
            //kad se otvori forma ideja je da kreiram id za novi racun, koji cu dodeljivati svakoj stavci racuna, ako je empty obrisacu ga na kraju aplikacije
            
            id_racun=(from r in ds.Racun
                      select r.id_racun).Max(); //poslednji id racun ce uvek biti najveci
            dgvRacun.DataSource=ds.Racun;
            dgvTrenutniRacun.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJelo.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            pOsvezi=AzurirajTrenutniRacun;

            dtTrenutniRacun = ds.Stavka_racuna.Copy();
            dtTrenutniRacun.Clear();

            DateTime min = (from r in ds.Racun
                                 select r.datum).Min();
            DateTime max = (from r in ds.Racun
                            select r.datum).Max();
            dtpMin.MinDate=min;
            dtpMin.MaxDate=max;
            dtpMax.MaxDate=max;
            dtpMax.MinDate=min;
            lblNajprodavanijeJelo.Text=Najprodavanije_jelo();
            tPomeraj=new Task(Pomeraj);
            tPomeraj.Start();
            tUvecaj_smanji=new Task(PromeniFont);
            tUvecaj_smanji.Start();
        }

        void Filtriraj_datum(DateTime min,DateTime max)
        {
            var filtrirani=from r in ds.Racun
                           where r.datum.Date >=min.Date && r.datum.Date <=max.Date
                           select r;
            int broj_redova = filtrirani.Count();
            if (broj_redova>0)
                dgvRacun.DataSource = filtrirani.CopyToDataTable(); //konvertujem u datatable
            else
                dgvRacun.DataSource=null;
        }

        public delegate void Osvezi();
        public static Osvezi pOsvezi; 
         public void AzurirajTrenutniRacun()
        {
            daStavka.Fill(ds.Stavka_racuna);
            dtTrenutniRacun = ds.Stavka_racuna.Copy();
            dtTrenutniRacun.Clear();
            var filter = from s in ds.Stavka_racuna
                         where s.id_racun==id_racun
                         select s;
            DataRow racunRow = ds.Racun.FindByid_racun(id_racun);
            int ukupna_cena = 0;
            foreach (var red in filter)
            {         
                ukupna_cena+=(red.cenaJelo+red.cenaPrilog)*red.kolicina;

                DataRow newRow = dtTrenutniRacun.NewRow();
                newRow["id_racun"] = red.id_racun;
                newRow["id_jelo"]=red.id_jelo;
                newRow["id_prilog"]=red.id_prilog;
                newRow["cenaPrilog"]=red.cenaPrilog;
                newRow["cenaJelo"]=red.cenaJelo;
                newRow["kolicina"]=red.kolicina;
                dtTrenutniRacun.Rows.Add(newRow);
            }
            racunRow["ukupna_cena"]=ukupna_cena;
            daRacun.Update(racunRow);

            //dgvRacun.DataSource = ds.Racun;
            Filtriraj_datum(dtpMin.Value, dtpMax.Value);//naknadna logika
            dgvTrenutniRacun.DataSource=dtTrenutniRacun;
        }

       
        private void txtFindJelo_TextChanged(object sender, EventArgs e)
        {
            var redovi = from j in ds.Jelo
                         where j.naziv.ToLower().StartsWith(txtFindJelo.Text.ToLower())
                         select j;
            DataTable filtriranaTabela = ds.Jelo.Copy();
            filtriranaTabela.Rows.Clear();

            foreach(var red in redovi)
            {
                DataRow noviRed=filtriranaTabela.NewRow();
                for (int i = 0; i < ds.Jelo.Columns.Count; i++)
                {
                    noviRed[i] = red[i];
                }
                filtriranaTabela.Rows.Add(noviRed);
            }
            dgvJelo.DataSource=filtriranaTabela;

        }
        
        private void btnDodajJela_Click(object sender, EventArgs e)
        {
            DodajJeloForm form = new DodajJeloForm();
            form.Show();
        }

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            //for (int i = ds.Stavka_racuna.Rows.Count-1; i>=0; i--)
            //{
            //    DataRow red = ds.Stavka_racuna.Rows[i];

            //    {
            //        red.Delete();
            //    }
            //}

            //daStavka.Update(ds.Stavka_racuna);


            for (int i = ds.Racun.Rows.Count-1; i>=0; i--)
            {
                DataRow red = ds.Racun.Rows[i];
                int ukupna_cena = Convert.ToInt32(red["ukupna_cena"]);
                if (ukupna_cena == 0)
                {
                    red.Delete();
                }
            }
            daRacun.Update(ds.Racun);   
        }

        private void rbOpadajuce_CheckedChanged(object sender, EventArgs e)
        {
            if(rbRastuce.Checked)
            {
                var redovi = from j in ds.Jelo
                             orderby j.cena
                             select j;

                DataTable filtrirano = ds.Jelo.Copy();
                filtrirano.Rows.Clear();
                foreach (var red in redovi)
                {
                    DataRow novi = filtrirano.NewRow();
                    for (int i = 0; i < ds.Jelo.Columns.Count; i++)
                    {
                        novi[i] = red[i];
                    }

                    filtrirano.Rows.Add(novi);
                }
                dgvJelo.DataSource=filtrirano;
            }
            else if(rbOpadajuce.Checked)
            {
                var redovi = from j in ds.Jelo
                             orderby  j.cena descending
                             select j;

                DataTable filtrirano = ds.Jelo.Copy();
                filtrirano.Rows.Clear();
                foreach (var red in redovi)
                {
                    DataRow novi = filtrirano.NewRow();
                    for (int i = 0; i < ds.Jelo.Columns.Count; i++)
                    {
                        novi[i] = red[i];
                    }

                    filtrirano.Rows.Add(novi);
                }
                dgvJelo.DataSource=filtrirano;
            }

        }
        public static bool IsPositiveCena(string text)
        {
            if (decimal.TryParse(text, out decimal value))
            {
                if (value >= 0)
                {
                    return true;
                }
            }

            return false;
        }

        private void btnIzbrisiStavku_Click(object sender, EventArgs e)
        {
            if (dgvTrenutniRacun.SelectedRows.Count > 0)
            {
                int id_jelo = (int)dgvTrenutniRacun.SelectedRows[0].Cells["id_jelo"].Value;
                int id_prilog = (int)dgvTrenutniRacun.SelectedRows[0].Cells["id_prilog"].Value;
                int cenaJelo= (int)dgvTrenutniRacun.SelectedRows[0].Cells["cenaJelo"].Value;
                int cenaPrilog= (int)dgvTrenutniRacun.SelectedRows[0].Cells["cenaPrilog"].Value;
                int kolicina= (int)dgvTrenutniRacun.SelectedRows[0].Cells["kolicina"].Value;
               
                int rz=daStavka.Delete(id_racun,id_jelo,id_prilog,cenaJelo,cenaPrilog,kolicina);
                if (rz>0) MessageBox.Show("Uspesno ste obrisali stavku sa racuna");
                pOsvezi();
            }
        }

        private void btnIzbrisiSve_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in ds.Stavka_racuna.Rows)
            {
                if ((int)row["id_racun"] == id_racun)
                {
                    int id_jelo = (int)row["id_jelo"];
                    int id_prilog = (int)row["id_prilog"];
                    int cenaJelo = (int)row["cenaJelo"];
                    int cenaPrilog = (int)row["cenaPrilog"];
                    int kolicina = (int)row["kolicina"];

                    int rz=daStavka.Delete(id_racun, id_jelo, id_prilog, cenaJelo, cenaPrilog, kolicina);
                    if (rz>0) MessageBox.Show("Uspesno ste obrisali sve stavke sa racuna");
                }
            }
            pOsvezi();
        }

        private void dtpMin_ValueChanged(object sender, EventArgs e)
        {
            Filtriraj_datum(dtpMin.Value, dtpMax.Value);
        }

        private void btnGrafika_Click(object sender, EventArgs e)
        {
            if (dgvJelo.SelectedRows.Count > 0)
            {              

                pnl.Paint+=Pnl_Paint; 
                pnl.Invalidate();
                lblGrafika.Show();
              
            }
               
        }
       
        private void dtpMax_ValueChanged(object sender, EventArgs e)
        {
            Filtriraj_datum(dtpMin.Value, dtpMax.Value);

        }

    }
}
