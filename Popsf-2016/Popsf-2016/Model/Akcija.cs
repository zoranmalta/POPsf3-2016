using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdavnicaNamestaja.model
{
    public class Akcija
    {
        public int Id { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumZavrsetka { get; set; }
        public Namestaj KomadNamestaja { get; set; }
        public double Popust { get; set; }
        public bool Obrisan { get; set; }

        public Akcija() { }

        public Akcija(int Id,DateTime DatumPocetka,DateTime DatumZavrsetka,Namestaj KomadNamestaja,double Popust,bool Obrisan)
        {
            this.Id = Id;
            this.DatumPocetka = DatumPocetka;
            this.DatumZavrsetka = DatumZavrsetka;
            this.KomadNamestaja = KomadNamestaja;
            this.Popust = Popust;
            this.Obrisan = Obrisan;
        }
    }
}
