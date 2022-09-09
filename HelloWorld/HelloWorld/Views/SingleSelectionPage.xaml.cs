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
    public partial class SingleSelectionPage : ContentPage
    {
        public SingleSelectionPage()
        {
            InitializeComponent();

            BindingContext = new MovieViewModel();
        }

        private void movieList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var previous = (e.PreviousSelection.FirstOrDefault() as Movie)?.Name; //previous secim bos değil ise  Name Property sini  değişkene at
            var current = (e.CurrentSelection.FirstOrDefault() as Movie)?.Name;

            lblCurrent.Text = current;
            lblPrevious.Text = previous;
        }
    }
}