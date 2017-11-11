using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdavnicaNamestaja.model
{
    public class Kupci
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Telefon { get; set; }
        public bool Obrisan { get; set; }

        public Kupci(int Id,string Ime, string Prezime,string Telefon,bool Obrisan)
        {
            this.Id = Id;
            this.Ime = Ime;
            this.Prezime = Prezime;
            this.Telefon = Telefon;
            this.Obrisan = Obrisan;
        }
    }
}
