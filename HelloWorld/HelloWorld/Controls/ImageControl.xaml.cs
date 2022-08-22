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
    public partial class ImageControl : ContentPage
    {
        public ImageControl()
        {
            InitializeComponent();

            //image.Source = ImageSource.FromResource("HelloWorld.Images.anastasia--12260189.jpg");

            image.Source = Device.RuntimePlatform == Device.Android ?
                ImageSource.FromFile("bg2.jpg") :
                ImageSource.FromFile("bg.jpg");
        }
    }
}