using System;
using System.Collections.Generic;
using System.Text;

namespace CasusRitAfronden.Models
{
    public class Rit
    {
        public int RitId { get; set; }
        public DateTime? StartTijd { get; set; }
        public DateTime? EindTijd { get; set; }
        public string Status { get; set; }
        public List<AfleverStop>? AfleverStops {  get; set; }

        public Rit(DateTime startTijd, DateTime eindTijd, string status)
        {
            StartTijd = startTijd;
            EindTijd = eindTijd;
            Status = status;
        }


        public void StartRit()
        {
            StartTijd = DateTime.Now;
            Status = "Onderweg";
        }

        public void RondRitAf()
        {
            EindTijd = DateTime.Now;
            Status = "Afgerond";
        }

        // Methode om de volgende afleverstop te tonen moet Index verhogen
        public void ToonVolgendeStop()
        {
            if (AfleverStops != null && AfleverStops.Count > 0)
            {
                var volgendeStop = AfleverStops[0];
                Console.WriteLine($"Volgende stop: {volgendeStop}");
            }
            else
            {
                Console.WriteLine("Geen afleverstops beschikbaar.");
            }
        }
    }
}
