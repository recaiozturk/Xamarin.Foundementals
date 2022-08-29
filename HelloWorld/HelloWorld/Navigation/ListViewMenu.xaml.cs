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
    public partial class ListViewMenu : ContentPage
    {
        public ListViewMenu()
        {
            InitializeComponent();

            itemList.ItemsSource = new ListItemPageModel[]
            {
                new ListItemPageModel{Title="First",PageType=typeof(FirstPage)},
                new ListItemPageModel{Title="Second",PageType=typeof(SecondPage)},
                new ListItemPageModel{Title="Third",PageType=typeof(ThirdPage)}
            };
        }

        private async void itemList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as ListItemPageModel;

            if (item == null)
                return;

            //sayfa üretiyoruz
            Page page=(Page) Activator.CreateInstance(item.PageType);
            await Navigation.PushAsync(page);
        }
    }
}