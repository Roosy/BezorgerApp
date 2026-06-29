using System;
using System.Collections.Generic;
using System.Text;

namespace BezorgerApp.Models
{
    public class Werkdag
    {
        public List<Rit>? Ritten { get; set; }

        public int TotaalBezorgingen =>
            Ritten?.SelectMany(r => r.AfleverStops).Count() ?? 0;

        public int Succesvol =>
            Ritten?.SelectMany(r => r.AfleverStops).Count(s => s.IsSuccesvol) ?? 0;

        public int Problemen =>
            Ritten?.SelectMany(r => r.AfleverStops).Count(s => s.HeeftProbleem) ?? 0;

        public double AfstandKm { get; set; }
    }
}
