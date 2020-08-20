using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkovljeviProcesi
{
    class BrojKorisnika
    {
        private int brojKorisnika;
        private int brojNekorisnika;

        public BrojKorisnika()
        {
        }

        public BrojKorisnika(int brojKorisnika, int brojNekorisnika)
        {
            this.brojKorisnika = brojKorisnika;
            this.brojNekorisnika = brojNekorisnika;
        }

        public int setBrojKorisnika { get => brojKorisnika; set => brojKorisnika = value; }
        public int setBrojNekorisnika { get => brojNekorisnika; set => brojNekorisnika = value; }
    }
}
