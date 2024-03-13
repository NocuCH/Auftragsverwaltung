using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auftragserfassung
{
    public class Artikel : INotifyPropertyChanged{
        public int Id { get; private set; }
        public int Artikelnummer { get; private set; }
        public string Bezeichnung { 
            get { return Bezeichnung; }
            set { 
                Bezeichnung = value;
                propertyChanged(nameof(Bezeichnung));
            }
        }
        public double Preis { 
            get { return Preis; }
            set { 
                Preis = value;
                propertyChanged(nameof(Preis)); 
            }
        }
        public Artikelgruppe Gruppe { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void propertyChanged(string property) {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
