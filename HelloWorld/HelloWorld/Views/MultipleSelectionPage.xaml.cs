using HelloWorld.Models;
using HelloWorld.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MultipleSelectionPage : ContentPage
    {
        public MultipleSelectionPage()
        {
            InitializeComponent();

            BindingContext = new MovieViewModel();
        }

        private void movieList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var previous = e.PreviousSelection;
            var current = e.CurrentSelection;



            for (int i = 0; i < previous.Count; i++)
            {
                lblCurrent.Text += (previous[i] as Movie)?.Name + " ";
            }

            for (int i = 0; i < current.Count; i++)
            {
                lblCurrent.Text += (current[i] as Movie)?.Name + " ";
            }
        }
    }

    

        
        
}