using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdavnicaNamestaja.model
{
    public class Racun
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public Kupci Kupac { get; set; }
        public bool Obrisan { get; set; }
        public List<StavkaProdajeNamestaja> ListaStavki { get; set; } = new List<StavkaProdajeNamestaja>();
        public List<Usluga> ListaUsluga { get; set; } = new List<Usluga>();

        public Racun(int Id, DateTime Datum, Kupci Kupac, bool Obrisan, List<StavkaProdajeNamestaja>ListaStavki,List<Usluga>
            ListaUsluga) {

        }
    }
}
