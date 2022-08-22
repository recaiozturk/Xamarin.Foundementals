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
    public partial class StackLayoutDemo3 : ContentPage
    {
        public StackLayoutDemo3()
        {
            //action barrı gizler
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }
    }
}