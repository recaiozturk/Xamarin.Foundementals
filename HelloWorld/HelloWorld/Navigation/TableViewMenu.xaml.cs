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
    public partial class TableViewMenu : ContentPage
    {
        public TableViewMenu()
        {
            InitializeComponent();
        }

        async void navigateToPage(object sender, EventArgs e)
        {
            string type = (sender as TextCell).CommandParameter.ToString();

            Type pageType = Type.GetType("HelloWorld.Navigation." + type +",HelloWorld");

            Page page = (Page)Activator.CreateInstance(pageType);

            await Navigation.PushAsync(page);
        }
    }
}