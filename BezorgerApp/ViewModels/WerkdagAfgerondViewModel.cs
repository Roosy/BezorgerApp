using CasusRitAfronden.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace CasusRitAfronden.ViewModels
{
    public class WerkdagAfgerondViewModel
    {
        public Werkdag Werkdag { get; set; }

        public ICommand UitloggenCommand { get; }

        public WerkdagAfgerondViewModel(Werkdag werkdag)
        {
            Werkdag = werkdag;

            UitloggenCommand = new Command(() =>
            {
                // redirect naar login
            });
        }

        public int Totaal => Werkdag.TotaalBezorgingen;
        public int Succesvol => Werkdag.Succesvol;
        public int Problemen => Werkdag.Problemen;
        public double Afstand => Werkdag.AfstandKm;
    }
}
