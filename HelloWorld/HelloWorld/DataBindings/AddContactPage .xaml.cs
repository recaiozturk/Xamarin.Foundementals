using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.DataBindings
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddContactPage : ContentPage
    {
        ContactVieModel viewModel;
        public AddContactPage()
        {
            InitializeComponent();

            viewModel = new ContactVieModel
            {
                Name ="Sadık Turan",
                Website="https://www.sadikturan.com",
                Favorite=true,
                Phone=05322563691
            };

            BindingContext = viewModel;
        }

        //async void openWebsiteButton_Clicked(object sender, EventArgs e)
        //{
        //    await Browser.OpenAsync(new Uri(viewModel.Website), BrowserLaunchMode.SystemPreferred);
        //}
    }
}