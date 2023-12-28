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
    public partial class DodajStavkuRacunaForm : Form
    {
        int id_jelo;
        List<Prilog> prilozi;
        public DodajStavkuRacunaForm(int id)
        {
            InitializeComponent();
            id_jelo = id;
            prilozi=new List<Prilog>();
            var Red=(from j in StartForm.ds.Jelo
                    where j.id_jelo==id
                    select j).First();
            string naziv = Red["naziv"].ToString();
            int cena = (int)Red["cena"];
            txtNazivJela.Text = naziv;
            txtCenaJela.Text=cena.ToString();

            var redovi = from pr in StartForm.ds.Pripadnost
                         join j in StartForm.ds.Jelo on pr.id_jelo equals j.id_jelo
                         join p in StartForm.ds.Prilog on pr.id_prilog equals p.id_prilog
                         where j.id_jelo==id
                         select p;
            int we=redovi.Count();
            foreach (var red in redovi)
            {
                int id_prilog = (int)red["id_prilog"];
                 naziv = (string)red["naziv"];
                 cena = (int)red["cena"];
                prilozi.Add(new Prilog(id_prilog, naziv, cena));
            }
            clbPrilozi.DataSource=prilozi;
            clbPrilozi.DisplayMember = "naziv";

        }

        private void clbPrilozi_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                for (int i = 0; i < clbPrilozi.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        clbPrilozi.SetItemChecked(i, false);
                    }
                }
            }
        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            string naziv_priloga = "";
            if (clbPrilozi.CheckedItems.Count == 1)
            {
                naziv_priloga = clbPrilozi.CheckedItems[0].ToString();
                var prilog = (from p in StartForm.ds.Prilog
                              where naziv_priloga==p.naziv
                              select p).FirstOrDefault();

                int id_prilog = (int)prilog["id_prilog"];
                int cena_prilog = (int)prilog["cena"];
                int cena_jelo = (from j in StartForm.ds.Jelo
                                 where j.id_jelo==id_jelo
                                 select j.cena).First();

                //posle dodaj prilog  NULL ako nije kliknuo koristi enum

                int broj_stavki = (from s in StartForm.ds.Stavka_racuna
                                   where s.id_racun==StartForm.id_racun && s.id_jelo==id_jelo && s.id_prilog==id_prilog
                                   select s).Count();
                if (broj_stavki==0)
                {
                    StartForm.daStavka.Insert(StartForm.id_racun, id_jelo, id_prilog, cena_jelo, cena_prilog, 1);
                    StartForm.daStavka.Fill(StartForm.ds.Stavka_racuna);
                }
                else
                {

                    var red_stavke = (from s in StartForm.ds.Stavka_racuna
                                      where s.id_racun==StartForm.id_racun && s.id_jelo==id_jelo && s.id_prilog==id_prilog
                                      select s).First();
                    int kolicina = (int)red_stavke["kolicina"];
                    kolicina++;
                    red_stavke["kolicina"]=kolicina;
                    StartForm.daStavka.Update(StartForm.ds.Stavka_racuna);
                }


                ////////////////////////////////////////////////////////
                var red_racuna = (from r in StartForm.ds.Racun
                                  where r.id_racun==StartForm.id_racun
                                  select r).First();
                red_racuna.ukupna_cena+=cena_prilog+cena_jelo;

                StartForm.daRacun.Update(StartForm.ds.Racun);
                StartForm.pOsvezi();
                MessageBox.Show("Uspesno ste dodali stavku na racun");
            }
            else
                MessageBox.Show("Morate odabrati stavku za prilog.");
            

        }
    }
}
