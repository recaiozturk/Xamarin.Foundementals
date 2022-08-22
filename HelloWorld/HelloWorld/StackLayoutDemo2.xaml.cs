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
    public partial class StackLayoutDemo2 : ContentPage
    {
        public StackLayoutDemo2()
        {
            //action barrı gizler
            NavigationPage.SetHasNavigationBar(this, false);

            InitializeComponent();
        }
    }
}