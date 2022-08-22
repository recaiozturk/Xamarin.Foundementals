using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloWorld
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            slider.Value = 0.5;

            
        }

        async void Handle_Click(object sender,EventArgs e)
        {
            //Berlitile nsayfaya gider - push eder
            await Navigation.PushAsync(new NextPage());
        }






    }
}
