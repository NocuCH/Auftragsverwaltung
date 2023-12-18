using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auftragserfassung
{
    public class Auftrag
    {
        public int Id { get; set; }
        public int Auftragsnummer { get; set; }
        public DateTime Datum { get; set; }
        public Kunde Kunde { get; set; }
        public virtual ICollection<Position> Positions { get; set; }
    }
    public class Position 
    {
        public int Id { get; set; }
        public int Nummer { get; set; }
        public Artikel Artikel { get; set; }
        public int Anzahl { get; set; }
    }
}
