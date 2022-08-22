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
    public partial class PickerControl : ContentPage
    {
        public PickerControl()
        {
            InitializeComponent();

            LoadModels();
        }

        void LoadModels()
        {
            var models = new List<String>
            {
                "Opel","Mercedes","Lambborgini","Wolswagen"
            };

            foreach (var item in models)
            {
                picker.Items.Add(item);
            }
        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = picker.SelectedIndex;

            if(selectedIndex != -1)
            {
                labelResult.Text= "From Code Behind :" + picker.Items[selectedIndex];
                
            }

            //var picker = ((Picker)sender);
        }
    }
}