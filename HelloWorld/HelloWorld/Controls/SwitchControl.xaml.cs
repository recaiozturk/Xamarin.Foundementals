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
    public partial class SwitchControl : ContentPage
    {
        public SwitchControl()
        {
            InitializeComponent();
        }

        private void swwitch1_Toggled(object sender, ToggledEventArgs e)
        {
            lblResult.Text=e.Value.ToString();
        }
    }
}