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
    public partial class ListViewEvents : ContentPage
    {

        List<MovieGroup> movieGroups = new List<MovieGroup>();
        public ListViewEvents()
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

        private void lisView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //DisplayAlert("Selected", "Selected", "OK");

            var item = e.SelectedItem as Movie;
            var itemIndex = e.SelectedItemIndex;

            lblResult.Text += item.Name + "is selected. \n";
            lblResult.Text += "item index :" + itemIndex.ToString() + "\n";
        }

        private void lisView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //DisplayAlert("Selected", "Tapped", "OK");

            var item = e.Item as Movie;
            var itemIndex = e.ItemIndex;
            var group=e.Group as MovieGroup;

            lblResult.Text += item.Name + "is tapped. \n";
            lblResult.Text += "item index :" + itemIndex.ToString() + "\n";
            lblResult.Text += "group name:" + group.Title + "\n";
            lblResult.Text += "\n" ;
        }
    }
}