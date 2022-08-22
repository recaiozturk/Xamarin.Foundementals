using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Lists
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModelBinding : ContentPage
    {
        public ModelBinding()
        {
            InitializeComponent();

            var movies = new List<Movie>
            {
                new Movie{Id=1,Name="The Dark Knight",Director="Christopher Nolan",ImageUrl="https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_.jpg"},
                new Movie{Id=2,Name="Inception",Director="Christopher Nolan",ImageUrl="https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_.jpg"},
                new Movie{Id=3,Name="Intersteller",Director="Christopher Nolan",ImageUrl="https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_.jpg"},
                new Movie{Id=4,Name="Prestige",Director="Christopher Nolan",ImageUrl="https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_.jpg"},
                new Movie{Id=5,Name="Tenet",Director="Christopher Nolan",ImageUrl="https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_.jpg"}
            };

            lisView.ItemsSource = movies;
        }

       
    }
}