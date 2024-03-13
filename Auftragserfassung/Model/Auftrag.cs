using Auftragserfassung.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auftragserfassung
{
    public class Auftrag : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public int Auftragsnummer { get; set; }
        public DateTime Datum {
            get { return datum; } 
            set {
                datum = value;
                this.propertyChanged(nameof(Datum));
            }
        }
        public Kunde Kunde { get; set; }
        public virtual ICollection<Position> Positionen { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        private DateTime datum;
        public Auftrag() {
            Kunde = new Kunde();
        }
        private void propertyChanged(string property) {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
