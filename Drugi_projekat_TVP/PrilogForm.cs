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
    public partial class PrilogForm : Form
    {
        RestoranDataSet ds;
        RestoranDataSetTableAdapters.PrilogTableAdapter da;
        public PrilogForm()
        {
            InitializeComponent();
            ds = new RestoranDataSet();
            da=new RestoranDataSetTableAdapters.PrilogTableAdapter();
        }

        private void btnDodajPrilog_Click(object sender, EventArgs e)
        {
            if(StartForm.IsPositiveCena(txtCenaPriloga.Text)&&txtNazivPriloga.Text.Length>0)
            {
                int rezultat = da.Insert(txtNazivPriloga.Text, int.Parse(txtCenaPriloga.Text));
                if (rezultat > 0)
                {
                    MessageBox.Show("Uspesno ste dodali prilog u bazu");
                }
                
            }
            else
            {
                MessageBox.Show("Morate uneti ispravne podatke!");
            }
            
        }
    }
}
