using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.CollectionViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataBindingCollectionView : ContentPage
    {
        public DataBindingCollectionView()
        {
            InitializeComponent();

            var movies = new List<Movie>
            {
                new Movie{Id=1,Raiting=4.1,Name="The Dark Knight",Director="Christopher Nolan",ImageUrl="https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_.jpg"},
                new Movie{Id=2,Raiting=4.2,Name="Inception",Director="Christopher Nolan",ImageUrl="https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_.jpg"},
                new Movie{Id=3,Raiting=3.1,Name="Intersteller",Director="Christopher Nolan",ImageUrl="https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_.jpg"},
                new Movie{Id=4,Raiting=4.7,Name="Prestige",Director="Christopher Nolan",ImageUrl="https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_.jpg"},
                new Movie{Id=5,Raiting=5.0,Name="Tenet",Director="Christopher Nolan",ImageUrl="https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_.jpg"}
            };

            movieList.ItemsSource = movies;

        }



    }
}