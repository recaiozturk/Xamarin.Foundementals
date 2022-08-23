using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Lists
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ObservableData : ContentPage
    {
        ObservableCollection<Movie> movies = new ObservableCollection<Movie>();
       
        public ObservableData()
        {
            InitializeComponent();

            movies.Add(new Movie { Id = 1, Name = "The Dark Knight", Director = "Christopher Nolan", ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_.jpg" });
            movies.Add(new Movie { Id = 2, Name = "Inception", Director = "Christopher Nolan", ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_.jpg" });
            movies.Add(new Movie { Id = 3, Name = "Intersteller", Director = "Christopher Nolan", ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_.jpg" });
            movies.Add(new Movie { Id = 4, Name = "Prestige", Director = "Christopher Nolan", ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_.jpg" });

            lisView.ItemsSource = movies;
        }


        private void addMovie_Clicked(object sender, EventArgs e)
        {
            movies.Add(new Movie { Id = 4, Name = "Prestige", Director = "Christopher Nolan", ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_.jpg" });

            lblCount.Text =movies.Count.ToString();
        }

        private void deleteMovie_Clicked(object sender, EventArgs e)
        {
            movies.RemoveAt(movies.Count - 1);

            lblCount.Text = movies.Count.ToString();
        }
    }
}