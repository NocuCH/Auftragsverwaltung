using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auftragserfassung
{
    public class Kunde
    {
        public int Id { get; set; }
        public int KundenNr { get; set; }
        public string Name { get; set; }
        public string Strasse { get; set; }
        public string PLZ { get; set; }
        public string Ort { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Password { get; set; }
    }
}
