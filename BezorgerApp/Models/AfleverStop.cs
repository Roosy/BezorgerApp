using System;
using System.Collections.Generic;
using System.Text;

namespace BezorgerApp.Models
{
    public class AfleverStop
    {
        public int StopId { get; set; }
        public int Volgnummer { get; set; }
        public Bestelling Bestelling { get; set; }
        public string KlantNaam => $"{Bestelling.Voornaam} {Bestelling.Tussenvoegsel} {Bestelling.Achternaam}";
        public string Adres => $"{Bestelling.Straat} {Bestelling.Huisnummer}, {Bestelling.Postcode} {Bestelling.Woonplaats}";
        public string Status { get; set; }
        public bool IsSuccesvol { get; set; }
        public bool HeeftProbleem { get; set; }


        public AfleverStop(int volgnummer, Bestelling bestelling, string status)
        {
            Volgnummer = volgnummer;
            Bestelling = bestelling;
            Status = status;
        }

    }
}
