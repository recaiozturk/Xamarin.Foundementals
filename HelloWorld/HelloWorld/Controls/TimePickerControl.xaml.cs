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
    public partial class TimePickerControl : ContentPage
    {
        DateTime _triggerTime;

        public TimePickerControl()
        {
            InitializeComponent();

            Device.StartTimer(TimeSpan.FromSeconds(1), OnTimeStick);
        }

        bool OnTimeStick()
        {
            if (switchuygulama.IsToggled && DateTime.Now >= _triggerTime)
            {
                switchuygulama.IsToggled = false;
                DisplayAlert("Time Alert:","" + entryUygulama.Text, "OK");
            }

            return true;
        }

        void SetTriggerTime()
        {
            if (switchuygulama.IsToggled)
            {
                _triggerTime = DateTime.Today + timePicker2.Time;

                if (_triggerTime > DateTime.Now)
                {
                    _triggerTime += TimeSpan.FromDays(1);
                }
            }
        }

        private void timePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
            {
                labelResult.Text = timePicker.Time.ToString();
            }


            //if (e.PropertyName == "Time")   ile de kullanılabilir
            //{

            //}
        }

        private void timePicker2_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
            {
                SetTriggerTime();
            }
        }

        private void switchuygulama_Toggled(object sender, ToggledEventArgs e)
        {
            SetTriggerTime();
        }
    }
}