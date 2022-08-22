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
    public partial class EntryControl : ContentPage
    {
        public EntryControl()
        {
            InitializeComponent();
        }

        private void name_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblTest.Text ="Changed :" + e.NewTextValue;
        }

        private void name_Completed(object sender, EventArgs e)
        {
            lblTest.Text = "Complated :";
        }
    }
}