using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auftragserfassung
{
    public class Artikelgruppe : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Artikelgruppe Parent { get; set; }
        public event PropertyChangedEventHandler? PropertyChanged;
        private void propertyChanged(string property) {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
