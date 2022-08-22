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
    public partial class DatePickerControl : ContentPage
    {
        public DatePickerControl()
        {
            InitializeComponent();
        }

        private void startDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            TimeSpan timeSpan=enddDatePicker.Date - startDatePicker.Date;
            labelResult.Text = String.Format("{0} day{1} between dates",
                timeSpan.Days,timeSpan.Days == 1 ? "" :"s");
        }
    }
}