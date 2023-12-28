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
    public partial class PrikazStavkiForm : Form
    {
        public PrikazStavkiForm(int id_racun)
        {
            InitializeComponent();
            var filter=from s in StartForm.ds.Stavka_racuna
                       where s.id_racun==id_racun
                       select s;
            int rz = filter.Count();
            if (rz>0)
                dataGridView1.DataSource=filter.CopyToDataTable();
            else
                dataGridView1.DataSource=null;
        }
    }
}
