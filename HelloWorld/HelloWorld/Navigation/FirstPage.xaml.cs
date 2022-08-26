using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        async private void NextPageButton_Clicked(object sender, EventArgs e)
        {
            var m = new Movie
            {
                Name="The Dark Knight",
                Director="Chris Nolan"
            };
            await Navigation.PushAsync(new SecondPage(m));
        }
    }
}