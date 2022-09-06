using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.CollectionViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SimpleCollectionView : ContentPage
    {
        public SimpleCollectionView()
        {
            InitializeComponent();

            products.ItemsSource = new String[]
            {
                "Samsung 1",
                "Samsung 2",
                "SAmsung 3"
            };
        }
    }
}