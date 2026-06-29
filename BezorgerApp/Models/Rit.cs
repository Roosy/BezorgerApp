using BezorgerApp;
using BezorgerApp.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace BezorgerApp.Models
{
    public class Rit
    {
        public int RitId { get; set; }
        public DateTime? StartTijd { get; set; }
        public DateTime? EindTijd { get; set; }
        public string Status { get; set; }
        public List<AfleverStop>? AfleverStops {  get; set; }
        public int _stopCount = 0;

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

    }
}
