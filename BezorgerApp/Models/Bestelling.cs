using System;
using System.Collections.Generic;
using System.Text;

namespace CasusRitAfronden.Models
{
    public class Bestelling
    {
        public int BestellingId { get; set; }
        public string? Voornaam { get; set; }
        public string? Tussenvoegsel { get; set; }
        public string? Achternaam { get; set; }
        public string? Straat { get; set; }
        public string? Huisnummer { get; set; }
        public string? Postcode { get; set; }
        public string? Woonplaats { get; set; }
        public List<Pakket> Pakketten { get; set; }
    }
}
