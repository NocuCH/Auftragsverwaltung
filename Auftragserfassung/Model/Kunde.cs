using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auftragserfassung
{
    public class Kunde : INotifyPropertyChanged 
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string vorname;
        private string nachname;
        private string strasse;
        private string plz;
        private string ort;
        private string email;
        private string website;
        private string passwort;
        public int Id { get; private set; }
        public int KundenNr { get; private set; }
        public string Vorname {
            get { return vorname; }
            set {
                vorname = value;
                this.propertyChanged(nameof(Vorname));
            }
        }
        public string Nachname {
            get { return nachname; }
            set {
                vorname = value;
                this.propertyChanged(nameof(Nachname));
            }
        }
        public string Strasse {
            get { return strasse; }
            set { 
                strasse = value;
                this.propertyChanged(nameof(Strasse));
            }
        }
        public string PLZ {
            get { return plz; }
            set { 
                plz = value;
                this.propertyChanged(nameof(PLZ));
            }
        }
        public string Ort {
            get { return ort; }
            set { 
                ort = value;
                this.propertyChanged(nameof(Ort));
            }
        }
        public string Email {
            get { return email; }
            set { 
                email = value;
                this.propertyChanged(nameof(Email));
            }
        }
        public string Website { 
            get { return website; }
            set { 
                website = value;
                this.propertyChanged(nameof(Website));
            }
        }
        public string Password {
            get { return passwort; }
            set { 
                passwort = value;
                this.propertyChanged(nameof(Password));
            }
        }
        public Kunde() {
            Id = 11;
            KundenNr = 11;
            vorname = "vorname";
            nachname = "nachname";
            strasse = "strasse";
            plz = "plz";
            ort = "ort";
            email = "email";
            website = "website";
            passwort = "passwort";
        }
        private void propertyChanged(string property) {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
