using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace HelloWorld.ViewModels
{

    public class MovieViewModel:INotifyPropertyChanged
    {
        public ObservableCollection<Movie> Movies { get; set; }
        public Movie SelectedMovie { get; set; }
        public string SelectedMovieName { get; set; }

        public ICommand MovieSelectionChangedCommand => new Command(MovieSelectionChanged);

        public MovieViewModel()
        {
            Movies = new ObservableCollection<Movie>
            {
                new Movie{Id=1,Raiting=4.1,Name="The Dark Knight",Director="Christopher Nolan",ImageUrl="https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_.jpg"},
                new Movie{Id=2,Raiting=4.2,Name="Inception",Director="Christopher Nolan",ImageUrl="https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_.jpg"},
                new Movie{Id=3,Raiting=3.1,Name="Intersteller",Director="Christopher Nolan",ImageUrl="https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_.jpg"},
                new Movie{Id=4,Raiting=4.7,Name="Prestige",Director="Christopher Nolan",ImageUrl="https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_.jpg"},
                new Movie{Id=5,Raiting=5.0,Name="Tenet",Director="Christopher Nolan",ImageUrl="https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_.jpg"}
            };

            SelectedMovie = Movies[2];
            MovieSelectionChanged();
        }

        

        void MovieSelectionChanged()
        {
            SelectedMovieName = "Seçilen Film :" +SelectedMovie.Name;
            OnPropertyChanged("SelectedMovieName");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
