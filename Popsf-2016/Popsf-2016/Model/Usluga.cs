using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdavnicaNamestaja.model
{
    public class Usluga
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public double Cena { get; set; }

        public Usluga(int Id,string Naziv, double Cena)
        {
            this.Id = Id;
            this.Naziv = Naziv;
            this.Cena = Cena;
        }
        public double vrednostStavkeUsluga(Usluga usluga)
        {
            return usluga.Cena;
        }
    }
}
