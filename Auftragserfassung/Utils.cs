using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auftragserfassung
{
    internal static class Utils
    {
        public static void WindowFunctionSelect()
        {

        }

        public static IQueryable<Auftrag> TemporalSelect(AuftragserfassungContext context, string filter) {
            var query = from order in context.Auftraege
                        select new Auftrag {
                            Id = order.Id,
                            Auftragsnummer = order.Auftragsnummer,
                            Datum = order.Datum,
                            Kunde = new Kunde {
                                Id = order.Kunde.Id,
                                KundenNr = order.Kunde.KundenNr,
                                Vorname = order.Kunde.Vorname,
                                Nachname = order.Kunde.Nachname,
                                Strasse = order.Kunde.Strasse,
                                PLZ = order.Kunde.PLZ,
                                Ort = order.Kunde.Ort,
                                Email = order.Kunde.Email,
                                Website = order.Kunde.Website,
                                Password = order.Kunde.Password
                            }
                        };

            return query;
        }

        public static void cteSelect()
        {

        }
    }
}
