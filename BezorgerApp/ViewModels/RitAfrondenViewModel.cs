using BezorgerApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using System.Collections.ObjectModel;


namespace BezorgerApp.ViewModels
{
    public class RitAfrondenViewModel : INotifyPropertyChanged
    {
        public Rit Rit { get; set; }

        public int TotaalLeveringen => Rit?.AfleverStops?.Count ?? 0;

        public int SuccesvolGeleverd =>
            Rit?.AfleverStops?.Count(s => s.IsSuccesvol) ?? 0;

        public int Problemen =>
            Rit?.AfleverStops?.Count(s => s.HeeftProbleem) ?? 0;

        public int Overgebleven =>
            TotaalLeveringen - (SuccesvolGeleverd + Problemen);

        public ICommand AfrondenCommand { get; }

        public RitAfrondenViewModel(Rit rit)
        {
            Rit = rit;

            AfrondenCommand = new Command(() =>
            {
                Rit.RondRitAf();
                OnPropertyChanged(nameof(Rit));
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}


