using HelloWorld.Models;
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
    public partial class NotifyPropertyChangedDemo : ContentPage
    {
        public NotifyPropertyChangedDemo()
        {
            InitializeComponent();

            //BindingContext = new NotifyViewModel();
        }
    }
}