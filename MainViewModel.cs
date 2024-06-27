using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiMemoryLeaks
{
    internal record RadioModel (string Name);

    internal partial class MainViewModel : ObservableObject
    {
        public ObservableCollection<RadioModel> Items { get; private set; } = [];

        [RelayCommand]
        private void RecreateList()
        {
            // Two GCs help it keep up if you tap very quickly
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Items = [
                new RadioModel("Manuel Neuer"),
                new RadioModel("Mats Hummels"),
                new RadioModel("Joshua Kimmich"),
                new RadioModel("Toni Kroos"),
                new RadioModel("Thomas Müller"),
                new RadioModel("Leroy Sané"),
                new RadioModel("Serge Gnabry"),
                new RadioModel("Leon Goretzka"),
                new RadioModel("Ilkay Gündogan"),
                new RadioModel("Timo Werner"),
                new RadioModel("Marco Reus"),
                new RadioModel("Niklas Süle"),
                new RadioModel("Kai Havertz"),
                new RadioModel("Kevin Trapp"),
                new RadioModel("Julian Brandt"),
                new RadioModel("Thilo Kehrer"),
                new RadioModel("Antonio Rüdiger"),
                new RadioModel("Emre Can"),
                new RadioModel("Jonas Hofmann"),
                new RadioModel("Lukas Klostermann"),
            ];
            OnPropertyChanged(nameof(Items));
        }

    }
}
