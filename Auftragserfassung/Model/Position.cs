using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auftragserfassung.Model {
    public class Position : INotifyPropertyChanged {
        public int Id { get; private set; }
        public int Nummer { get; private set; }
        public Artikel Artikel { get; private set; }
        public int Anzahl {
            get { return Anzahl; }
            set {
                Anzahl = value;
                propertyChanged(nameof(Anzahl));
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        private void propertyChanged(String property) {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
