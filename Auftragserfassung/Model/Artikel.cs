using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auftragserfassung
{
    public class Artikel
    {
        public int Id { get; set; }
        public int Artikelnummer { get; set; }
        public string Bezeichnung { get; set; }
        public double Preis {  get; set; }
        public Artikelgruppe Gruppe { get; set; }
    }
}
