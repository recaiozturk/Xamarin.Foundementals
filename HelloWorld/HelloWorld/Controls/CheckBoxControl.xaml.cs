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
    public partial class CheckBoxControl : ContentPage
    {
        public CheckBoxControl()
        {
            InitializeComponent();
        }

        private void checkBox_sinema_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            var result=e.Value.ToString();
            lblResult.Text=result;
        }
    }
}