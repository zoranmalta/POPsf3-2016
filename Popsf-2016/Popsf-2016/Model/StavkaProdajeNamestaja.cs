using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdavnicaNamestaja.model
{
    public class StavkaProdajeNamestaja

    {
        public int Id_Racun { get; set; }
        public int Id_Namestaj { get; set; }
        public int Kolicina { get; set; }

        public StavkaProdajeNamestaja(int Id,Namestaj Komad,int Kolicina)
        {
            this.Id_Racun = Id_Racun;
            this.Id_Namestaj = Id_Namestaj;
            this.Kolicina = Kolicina;
        }

        public double vrednostJedneStavke(Namestaj Komad,int Kolicina)
        {
            double vrednost = Komad.Cena * Kolicina;
            return vrednost;
        }
    }
}
