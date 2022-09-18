using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Databases
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppProperties : ContentPage
    {
        public AppProperties()
        {
            InitializeComponent();

            //Daha önce Propertylerde veri var mı
            if (Application.Current.Properties.ContainsKey("Theme"))
            {
                theme.Text=Application.Current.Properties["Theme"].ToString();
            }

            if (Application.Current.Properties.ContainsKey("Notifications"))
            {
                notifications.On = (bool)Application.Current.Properties["Notifications"];
            }
        }
        private void OnChanged(object sender, EventArgs e)
        {
            Application.Current.Properties["Theme"] = theme.Text;
            Application.Current.Properties["Notifications"] = notifications.On;

            //Direk bilgileri kaydeder.NOrmalde uygulama askıya alındığında kaydediyor --Kesin kayıt için bu methodu kullanıyoruz
            //Application.Current.SavePropertiesAsync();
        }

    }
}