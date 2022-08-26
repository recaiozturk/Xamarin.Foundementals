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
    public partial class ThirdPage : ContentPage
    {
        public ThirdPage()
        {
            InitializeComponent();
        }

        async private void PrevPageButton_Clicked(object sender, EventArgs e)
        {
            //gerideki sayfa -- önceki sayfa
            await Navigation.PopAsync();
        }

        async private void FirstPageButton_Clicked(object sender, EventArgs e)
        {
            //ilk sayfaya --en baaş götürür
            await Navigation.PopToRootAsync();
        }
    }
}