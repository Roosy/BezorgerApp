using System;
using System.Collections.Generic;
using System.Text;

namespace BezorgerApp.Models
{
    internal class ProbleemMelding
    {
        public int MeldingId { get; set; }
        public string Type { get; set; }
        public string Omschrijving { get; set; }
        public List<string> PhotoPaths { get; set; } = new();
        public DateTime Tijdstip { get; set; }


        public ProbleemMelding(int meldingId, string type, string omschrijving, DateTime tijdstip)
        {
            MeldingId = meldingId;
            Type = type;
            Omschrijving = omschrijving;
            Tijdstip = DateTime.Now;
        }

        public void RegistreerPrombleem()
        {
            // Code om de probleemmelding te registreren in de database of een ander systeem
            Console.WriteLine($"Probleemmelding geregistreerd: {Type} op {Tijdstip} : {Omschrijving}");
        }
    }
}
