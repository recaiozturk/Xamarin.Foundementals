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
    public partial class SimpleListView : ContentPage
    {
        public SimpleListView()
        {
            InitializeComponent();

            listview.ItemsSource = new string[]
            {
                "item code behind 1",
                "item code behind 2",
                "item code behind 3"
            };

        }
    }
}