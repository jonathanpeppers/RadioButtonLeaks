using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiMemoryLeaks
{
    internal record RadioModel (string Name);

    internal partial class MainViewModel : ObservableObject
    {
        public ObservableCollection<RadioModel> Items { get; } = [];

        [RelayCommand]
        private void RecreateList()
        {
            Items.Clear();

            GC.Collect();

            Items.Add(new RadioModel("Manuel Neuer"));
            Items.Add(new RadioModel("Mats Hummels"));
            Items.Add(new RadioModel("Joshua Kimmich"));
            Items.Add(new RadioModel("Toni Kroos"));
            Items.Add(new RadioModel("Thomas Müller"));
            Items.Add(new RadioModel("Leroy Sané"));
            Items.Add(new RadioModel("Serge Gnabry"));
            Items.Add(new RadioModel("Leon Goretzka"));
            Items.Add(new RadioModel("Ilkay Gündogan"));
            Items.Add(new RadioModel("Timo Werner"));
            Items.Add(new RadioModel("Marco Reus"));
            Items.Add(new RadioModel("Niklas Süle"));
            Items.Add(new RadioModel("Kai Havertz"));
            Items.Add(new RadioModel("Kevin Trapp"));
            Items.Add(new RadioModel("Julian Brandt"));
            Items.Add(new RadioModel("Thilo Kehrer"));
            Items.Add(new RadioModel("Antonio Rüdiger"));
            Items.Add(new RadioModel("Emre Can"));
            Items.Add(new RadioModel("Jonas Hofmann"));
            Items.Add(new RadioModel("Lukas Klostermann"));
        }

    }
}
