using HelloWorld.CollectionViews;
using HelloWorld.Controls;
using HelloWorld.DataBindings;
using HelloWorld.Lists;
using HelloWorld.Navigation;
using HelloWorld.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new Views.MainPage());

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
