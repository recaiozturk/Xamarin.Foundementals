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
    public partial class MasterPage : ContentPage
    {
        public MasterPage()
        {
            InitializeComponent();

            itemList.ItemsSource = new ListItemModel[]
            {
                new ListItemModel {Title="First",Description="First Description"},
                new ListItemModel {Title="Second",Description="Second Description"},
                new ListItemModel {Title="Third",Description="Third Description"}
            };

        }

        private async void itemList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item =e.Item as ListItemModel;

            if (item == null)
                return;

            await Navigation.PushAsync(new DetailsPage(item));

            itemList.SelectedItem=null;
        }
    }
}