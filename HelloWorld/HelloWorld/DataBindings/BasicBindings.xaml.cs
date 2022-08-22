using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.DataBindings
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasicBindings : ContentPage
    {
        public BasicBindings()
        {
            InitializeComponent();

            //label.BindingContext = slider;
            //label.SetBinding(Label.RotationProperty, "Value");

            //diğer yöntem
            //label.SetBinding(Label.TextProperty, new Binding("Value", source: slider));
        }
    }
}