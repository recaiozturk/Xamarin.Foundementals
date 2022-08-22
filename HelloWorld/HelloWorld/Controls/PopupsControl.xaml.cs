using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupsControl : ContentPage
    {
        public PopupsControl()
        {
            InitializeComponent();
        }

        private async void buttonDisplay_Clicked(object sender, EventArgs e)
        {
            await  DisplayAlert("Title", "Message Body", "Cancel");
        }

        private async void buttonResponse_Clicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Title", "Message Body", "OK", "Cancel");

            lblResult.Text=answer ? "OK" : "Cancel";
        }

        private async void getStringButton_Clicked(object sender, EventArgs e)
        {
            string answer = await DisplayActionSheet("Send To ?", "Cancel", "Delete", "Email", "Twitter", "Facebook");

            lblResult.Text=answer;
        }
    }
}