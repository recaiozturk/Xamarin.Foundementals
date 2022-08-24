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
    public partial class GroupingItems : ContentPage
    {

        List<MovieGroup> movieGroups= new List<MovieGroup>();   

        public GroupingItems()
        {
            InitializeComponent();

            movieGroups.Add(new MovieGroup("Komedi", "K")
            {
                 new Movie{Id=1,Name="Komedi 1",Director="Christopher Nolan",ImageUrl="https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_.jpg"},
                 new Movie{Id=1,Name="Komedi 2",Director="Christopher Nolan",ImageUrl="https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_.jpg"}
            });

            movieGroups.Add(new MovieGroup("Aksiyon", "A")
            {
                 new Movie{Id=1,Name="Aksyion 1",Director="Christopher Nolan",ImageUrl="https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_.jpg"},
                 new Movie{Id=1,Name="Aksyion 2",Director="Christopher Nolan",ImageUrl="https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_.jpg"}
            });

            movieGroups.Add(new MovieGroup("Gerilim", "G")
            {
                 new Movie{Id=1,Name="Gerilim 1",Director="Christopher Nolan",ImageUrl="https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_.jpg"},
                 new Movie{Id=1,Name="Gerilim 2",Director="Christopher Nolan",ImageUrl="https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_.jpg"}
            });

            lisView.ItemsSource = movieGroups;

        }

        
    }
}