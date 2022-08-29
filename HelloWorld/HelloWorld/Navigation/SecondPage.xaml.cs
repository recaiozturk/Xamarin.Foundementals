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
    public partial class SecondPage : ContentPage
    {

        public SecondPage()
        {
            InitializeComponent();
        }
        public SecondPage(Movie m)
        {
            InitializeComponent();

            BindingContext = m;
        }

        async private void NextPageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ThirdPage());
        }

        async private void PrevPageButton_Clicked(object sender, EventArgs e)
        {
            //gerideki sayfa -- önceki sayfa
            await Navigation.PopAsync();
        }
    }
}