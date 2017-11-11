using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdavnicaNamestaja.model
{
    public class Salon
    {
        public string Naziv { get; set; }
        public string Adresa{ get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public int PIB { get; set; }
        public int MaticniBroj { get; set; }
        public string ZiroRacun { get; set; }
    }
}
