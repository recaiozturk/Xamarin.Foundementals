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
    public partial class StepperControl : ContentPage
    {
        public StepperControl()
        {
            InitializeComponent();
        }

        private void stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            //e.NewValue
            //stepper.Value
            //double value = ((Stepper)sender).Value;

        }
    }
}