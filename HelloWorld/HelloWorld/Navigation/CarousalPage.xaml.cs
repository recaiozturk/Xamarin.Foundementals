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
    public partial class CarousalPage : CarouselPage
    {
        public CarousalPage()
        {
            InitializeComponent();

            ContentPage page = null;

            for (int i = 0; i < 10; i++)
            {
                page = new ContentPage();
                page.Content = new Label()
                {
                    Text = "Page For Döngüsünden " + i,
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,
                };
                this.Children.Add(page);
            }

        }
    }
}