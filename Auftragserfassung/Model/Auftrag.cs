using Auftragserfassung.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

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
        private ICommand saveCommand;
        public ICommand SaveCommand {
            get {
                if (saveCommand == null) {
                    saveCommand = new RelayCommand(
                        param => this.SaveObject()
                    );
                }
                return saveCommand;
            }
        }
        private ICommand newCommand;
        public ICommand NewCommand {
            get {
                if (newCommand == null) {
                    newCommand = new RelayCommand(
                        param => this.SaveObject()
                    );
                }
                return newCommand;
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private DateTime datum;
        public void SaveObject() {
            AuftragserfassungContext.Instance.Kunden.Add(this.Kunde);
            AuftragserfassungContext.Instance.Auftraege.Add(this);
            AuftragserfassungContext.Instance.SaveChanges();
        }
        public static ObservableCollection<Auftrag> selectAll() {
            var querry = AuftragserfassungContext.Instance.Auftraege.Include(x => x.Kunde).Select(x => x);
            var result = new ObservableCollection<Auftrag>();
            foreach (var auftrag in querry) {
                result.Add(auftrag);
            }
            return result;
        }
        private void propertyChanged(string property) {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
