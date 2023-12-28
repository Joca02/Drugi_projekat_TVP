using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drugi_projekat_TVP
{
    public partial class DodajJeloForm : Form
    {
        List<Prilog> prilozi;
        RestoranDataSet ds;
        RestoranDataSetTableAdapters.PrilogTableAdapter daPrilog;
        public DodajJeloForm()
        {
            InitializeComponent();
            prilozi = new List<Prilog>();
            ds=new RestoranDataSet();
            daPrilog=new RestoranDataSetTableAdapters.PrilogTableAdapter();
            daPrilog.Fill(ds.Prilog);
            var redovi = from p in ds.Prilog
                         select p;
            foreach(var red in redovi)
            {
                int id_prilog = (int)red["id_prilog"];
                string naziv = (string)red["naziv"];
                int cena = (int)red["cena"];
                prilozi.Add(new Prilog(id_prilog,naziv,cena));
            }
            clbPrilozi.DataSource=prilozi;
            clbPrilozi.DisplayMember = "naziv";          

        }

        private void btnDodajPrilog_Click(object sender, EventArgs e)
        {
            PrilogForm f = new PrilogForm();
            f.Show();
        }

        private void btnDodajJelo_Click(object sender, EventArgs e)
        {
            RestoranDataSetTableAdapters.PripadnostTableAdapter daPripadnost = new RestoranDataSetTableAdapters.PripadnostTableAdapter();
            RestoranDataSetTableAdapters.JeloTableAdapter daJelo = new RestoranDataSetTableAdapters.JeloTableAdapter();
            daJelo.Fill(ds.Jelo);
            if (StartForm.IsPositiveCena(txtCenaJela.Text) && txtNazivJela.Text.Length>0)
            {
                int rez_jela = daJelo.Insert(txtNazivJela.Text, int.Parse(txtCenaJela.Text));
                if (rez_jela>0)
                    MessageBox.Show("Jelo je uspesno dodato u bazu");
                ds.Jelo.Clear();
                daJelo.Fill(ds.Jelo);
                var id_jela = (from j in ds.Jelo
                               where j.naziv == txtNazivJela.Text
                               select j.id_jelo).First();

                int brojac_priloga = 0;
                for (int i = 0; i < clbPrilozi.Items.Count; i++)
                {
                    if (clbPrilozi.GetItemChecked(i))
                    {
                        daPripadnost.Insert(id_jela, i+1);  //npr ako je izabrano prvo jelo, njegov index je 0 a id je 1 
                        brojac_priloga++;
                    }
                }
                MessageBox.Show("Za "+txtNazivJela.Text+" je uneto "+brojac_priloga+" priloga");
            }
            else
                MessageBox.Show("Morate uneti ispravne podatke!");
            

        }
    }
}
