using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AcivityIndicatorContrrol : ContentPage
    {
        public AcivityIndicatorContrrol()
        {
            InitializeComponent();

            var imageSource = new UriImageSource
            {
                Uri = new Uri("https://images.pexels.com/photos/12328370/pexels-photo-12328370.jpeg"),
                CachingEnabled = false // her defasında resmi indirsin
            };

            image.Source = imageSource;

        }
    }
}