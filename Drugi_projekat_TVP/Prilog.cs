using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugi_projekat_TVP
{
    internal class Prilog
    {
        int id_prilog;
        string naziv;
        int cena;

        public Prilog(int id_prilog, string naziv, int cena)
        {
            this.id_prilog=id_prilog;
            this.naziv=naziv;
            this.cena=cena;
        }

        public int Id_prilog { get => id_prilog; set => id_prilog=value; }
        public string Naziv { get => naziv; set => naziv=value; }
        public int Cena { get => cena; set => cena=value; }

        public override string ToString()
        {
            return naziv;
        }
    }
}
